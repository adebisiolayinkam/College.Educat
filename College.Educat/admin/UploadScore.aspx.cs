using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{

    public partial class UploadScore : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                PopulateArms();
                PopulateClass();
                PopulateSubject();
                var setting = db.schoolsetups.FirstOrDefault();
                if (setting == null)
                {
                    Response.Redirect("AddSchoolInfo");
                }
                CurrentSessionLabel.Text = setting.currentsession;
                CurrentTermLabel.Text = setting.currentterm.ToString();
            }
        }

        public void PopulateArms()
        {

            var arm = from s in db.Arms select new { s.Id, s.armname };
            DropDownListArm.DataSource = arm.ToList();
            DropDownListArm.DataValueField = "Id";
            DropDownListArm.DataTextField = "armname";
            DropDownListArm.DataBind();
            DropDownListArm.Items.Insert(0, "--Select Your Arms--");

        }


        public void PopulateClass()
        {

            var Class = from c in db.classes select new { c.Id, c.classname };
            DropDownListClassId.DataSource = Class.ToList();
            DropDownListClassId.DataValueField = "Id";
            DropDownListClassId.DataTextField = "classname";
            DropDownListClassId.DataBind();
            DropDownListClassId.Items.Insert(0, "--Select Your classname--");

        }


        public void PopulateSubject()
        {

            var sub = from s in db.subjects select new { s.Id, s.subjectname };
            DropDownListSubject.DataSource = sub.ToList();
            DropDownListSubject.DataValueField = "Id";
            DropDownListSubject.DataTextField = "subjectname";
            DropDownListSubject.DataBind();
            DropDownListSubject.Items.Insert(0, "--Select Your Subjectname--");

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            string SavedPath = this.MapPath("~/temps/");
            //SpanError.Text = SavedPath;
            //return;
            if (fUpload.HasFile)
            {
                int filesize = fUpload.PostedFile.ContentLength;
                string filename = Server.HtmlEncode(fUpload.FileName);
                string extenstion = System.IO.Path.GetExtension(filename);

                if (!(extenstion.ToLower().Equals(".xls") || extenstion.ToLower().Equals(".xlsx")))
                {
                    lblMessage.Text = "Invalid File, only Excel file is expected";
                    return;
                }
                //File must  not be more than 100 KB
                if (filesize > 102400)
                {
                    lblMessage.Text = "File too large";
                    return;
                }
                string id = DateTime.Now.ToFileTime().ToString();// Session.SessionID.ToString();
                SavedPath += id + extenstion;
                fUpload.SaveAs(SavedPath);

                System.Data.DataTable dt = new System.Data.DataTable();
                Models.ImportExcel xl = new Models.ImportExcel() { FilePath = SavedPath };


                if (extenstion.Equals(".xls"))
                    dt = xl.GetData03();
                else
                    dt = xl.GetData07();

                tbScore.DataSource = dt;
                tbScore.DataBind();
            }
            else
            {
                lblMessage.Text = "There are no File Selected";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (tbScore.Rows.Count < 1)
            {
                lblMessage.Text = "You have not select any excel file containg scores";
                return;
            }
            if (tbScore.Rows[0].Cells.Count != 4)
            {
                lblMessage.Text = "You have selected an invalid excle file";
                return;
            }
            var session = CurrentSessionLabel.Text;
            var term = CurrentTermLabel.Text;
            bool valid = int.TryParse(DropDownListClassId.SelectedValue, out int level);
            if (!valid)
            {
                lblMessage.Text = "Selected Student Class is invalid";
                return; 
            }
            valid = int.TryParse(DropDownListSubject.SelectedValue, out int subject);
            if (!valid)
            {
                lblMessage.Text = "Selected subject is invalid";
                return;
            }
            if (DropDownListArm.SelectedIndex < 1)
            {
                lblMessage.Text = "Selected class arm is invalid";
                return;
            }

            List<Models.ImportError> errors = new List<Models.ImportError>();

            
            foreach (GridViewRow row in tbScore.Rows)
            {

                Models.ImportError ie = new Models.ImportError();

                valid = int.TryParse(row.Cells[2].Text, out int Ca);
                valid = int.TryParse(row.Cells[3].Text, out int Exam);
                valid = long.TryParse(row.Cells[0].Text, out long Id);
                if (!valid)
                {
                    ie.Id = Id.ToString();
                    ie.Error = "Invlaid Student ID";
                    errors.Add(ie);
                    continue;
                }

                var score = new studentsubjectregistrationandresult
                {
                    ca = Ca,
                    exam = Exam,
                    ca2 = 0,
                    classaverage = 0,
                    grade = "",
                    position = 0,
                    session = session,
                    term = int.Parse(term),
                    studentid = Id,
                    subjectid = subject,
                    teacherscomment = ""
                };
                db.studentsubjectregistrationandresults.Add(score);
                ie.Id = Id.ToString();
                try
                {
                    db.SaveChanges();
                   
                    ie.Error = "Saved successfully";
                   // errors.Add(ie);
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("Violation"))
                    {
                        ie.Error = "Scores exists";
                        //Score exists
                    }
                    else
                    {
                        ie.Error = ex.Message;
                    }

                }
                errors.Add(ie);
            }
            tbScore.DataSource = errors;
            tbScore.DataBind();
        }
    }
}