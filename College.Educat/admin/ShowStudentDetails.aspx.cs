using College.Educat.Models.Data;
using College.Educat.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class ShowStudentDetails : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            using (EducatContext db = new EducatContext())
            {
                var stud = from s in db.students
                           select new StuentView
                           {
                               ArmId = s.armId,
                               City = s.city,
                               currentclassId = s.currentclassId,
                               Currentsession = s.currentsession,
                               Currentterm = s.currentterm,
                               dob = s.dob,
                               Firstname = s.firstname,
                               Gender = s.gender,
                               Graduated = s.graduated,
                               Guardianemail = s.guardianemail,
                               Lastname = s.lastname,
                               Othername = s.othername,
                               Guardiannames = s.guardiannames,
                               Guardianphoneno = s.guardianphoneno,
                               Homeaddress = s.homeaddress,
                               Yearofentry = s.yearofentry,
                               Id = s.Id,
                               State = s.state,
                               Yearofgraduation = s.yearofgraduation
                           };
                GridView2.DataSource = stud.ToList().Take(5);
                GridView2.DataBind();

            }
        }

        protected void btnNewStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (EducatContext db = new EducatContext())
            {
                if (GuadiandphoneBox.Text == "")

                    LoadData();
                else
                {
                    var query = db.students.Where(x => x.guardianphoneno == this.GuadiandphoneBox.Text).ToList();
                    this.GridView2.DataSource = query;
                    this.GridView2.DataBind();
                }

            }
        }



        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView2.Rows[index];
            string studentid = (row.Cells[0].Text);

            if (e.CommandName == "edit")
            {
                Session["id"] = studentid;
                Response.Redirect($"edit.aspx?id={studentid}");
            }
            else if (e.CommandName == "delete")
            {
                using (EducatContext db = new EducatContext())
                {

                   // student d = db.students.FirstOrDefault(x => x.Id == long.Parse(studentid));
                    //db.students
                    long id = long.Parse(studentid);
                    student d = db.students.FirstOrDefault(x => x.Id == id);
                    try
                    {
                        db.students.Remove(d);
                        db.SaveChanges();
                        LoadData();
                    }
                    catch(Exception ex)
                    {
                        string msgb = ex.Message;
                        Response.Write("<script>alert('An error occurre while deleting the student');</script>");
                    }

                }
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}