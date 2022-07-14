using College.Educat.Models.Data;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class edit : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                PopulateCountry();
                PopulateArms();
                PopulateClass();
                LoadYears();


                if (Session["id"] == null)
                    Response.Redirect("ShowStudentDetails");

                long Id;
                Id = long.Parse(Session["id"].ToString());
                Loadstudentdata(Id);
            }
        }

        private void Loadstudentdata(long id)
        {

            var stud = db.students.FirstOrDefault(x => x.Id == id);
            if (stud != null)
            {
                SurnameBox.Text = stud.lastname;
                DobTextBox.Text = stud.dob.ToString("MM/dd/yyyy");
                FirstNameBox.Text = stud.firstname;
                OtherNameBox.Text = stud.othername;
                GenderDropDownList.SelectedValue = stud.gender;
                DropDownListClassID.SelectedValue = stud.currentclassId.ToString();
                CurrentSessionBox.Text = stud.currentsession;
                DropDownListCurrentTerm.Text = stud.currentterm.ToString();
                DropDownListArmId.SelectedValue = stud.armId.ToString();
                GuardianNameBox.Text = stud.guardiannames;
                GuardianPhoneNoBox.Text = stud.guardianphoneno;
                GuardianEmailBox.Text = stud.guardianemail;
                HomeAddressBox.Text = stud.homeaddress;
                CityBox.Text = stud.city;
                StateDropDownList.SelectedValue = stud.state.ToString();
                DropDownListYEntry.Text = stud.yearofentry.ToString();
                DobTextBox.Text = stud.dob.ToString();
                HiddenField1.Value = stud.Id.ToString();
                Image1.ImageUrl = $"~/aworan/aworan.ashx?sudentid={stud.Id}";
            }
        }

        private void LoadYears()
        {
            for (int i = DateTime.Now.AddYears(-10).Year; i <= DateTime.Now.Year; i++)
                DropDownListYEntry.Items.Add(i.ToString());
        }

        public void PopulateCountry()
        {

            var st = from s in db.states select new { s.Id, s.statename };
            StateDropDownList.DataSource = st.ToList();
            StateDropDownList.DataValueField = "Id";
            StateDropDownList.DataTextField = "statename";
            StateDropDownList.DataBind();
            StateDropDownList.Items.Insert(0, "--Select Your State--");

        }



        public void PopulateArms()
        {

            var arm = from s in db.Arms select new { s.Id, s.armname };
            DropDownListArmId.DataSource = arm.ToList();
            DropDownListArmId.DataValueField = "Id";
            DropDownListArmId.DataTextField = "armname";
            DropDownListArmId.DataBind();
            DropDownListArmId.Items.Insert(0, "--Select Your Arms--");

        }


        public void PopulateClass()
        {

            var Class = from c in db.classes select new { c.Id, c.classname };
            DropDownListClassID.DataSource = Class.ToList();
            DropDownListClassID.DataValueField = "Id";
            DropDownListClassID.DataTextField = "classname";
            DropDownListClassID.DataBind();
            DropDownListClassID.Items.Insert(0, "--Select Your classname--");

        }


        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                DateTime dob;
                bool valid = DateTime.TryParse(DobTextBox.Text, out dob);
                if (!IsValid)
                {
                    lblMessage.Text = "invalid date of birth";
                    return;
                }

                using (EducatContext db = new EducatContext())
                {
                    string lastname = (string)Session["lastname"];
                    var stu = db.students.FirstOrDefault(x => x.lastname == lastname);

                    if ( stu != null)
                    {
                        stu.lastname = Server.HtmlEncode(SurnameBox.Text);
                        stu.firstname = Server.HtmlEncode(FirstNameBox.Text);
                        stu.othername = Server.HtmlEncode(OtherNameBox.Text);
                        stu.gender = GenderDropDownList.SelectedValue;
                        stu.currentclassId = int.Parse(DropDownListClassID.SelectedValue);
                        stu.currentsession = Server.HtmlEncode(CurrentSessionBox.Text);
                        stu.currentterm = int.Parse(DropDownListCurrentTerm.Text);
                        stu.armId = int.Parse(DropDownListArmId.SelectedValue);
                        stu.guardiannames = Server.HtmlEncode(GuardianNameBox.Text);
                        stu.guardianphoneno = Server.HtmlEncode(GuardianPhoneNoBox.Text);
                        stu.guardianemail = Server.HtmlEncode(GuardianEmailBox.Text);
                        stu.homeaddress = Server.HtmlEncode(HomeAddressBox.Text);
                        stu.city = Server.HtmlEncode(CityBox.Text);
                        stu.state = int.Parse(StateDropDownList.SelectedValue);
                        stu.yearofentry=int.Parse(DropDownListYEntry.Text);
                        stu.dob = dob;
                       // stu.picture = imgbyte;
                        stu.graduated = false;
                        stu.yearofgraduation = 0;
                        if (stu.picture.Length <= 1024 && !FileUpload1.HasFile)
                        {
                            lblMessage.Text = "Your student must have a picture!!!";
                            return;
                        }
                        if (FileUpload1.HasFile)
                        {
                            string fln = FileUpload1.PostedFile.FileName;
                            string extension = System.IO.Path.GetExtension(fln);
                            bool acceptable = false;
                            bool toolarge = false;
                            toolarge = false;
                            toolarge = FileUpload1.PostedFile.ContentLength > 122880;
                            if (toolarge)
                            {
                                lblMessage.Text = "File you selected is too large, must not be more than 120KB!";
                                return;
                            }

                            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                            string[] allowedExtensions = { ".jpg", ".png", ".jpeg" };

                            for (int i = 0; i < allowedExtensions.Length; i++)
                                if (fileExtension == allowedExtensions[i])
                                {
                                    acceptable = true;
                                    break;
                                }

                            if (!acceptable)
                            {
                                lblMessage.Text = "File is not acceptable! It must be a jpg/png/jpeg of not more than 120kb in size";
                                return;
                            }

                            int length = FileUpload1.PostedFile.ContentLength;
                            byte[] imgbyte = new byte[length];
                            HttpPostedFile img = FileUpload1.PostedFile;

                            img.InputStream.Read(imgbyte, 0, length);
                            stu.picture = imgbyte;
                        }
                        //stu.parentid = 192001;
                        //lblMessage.Text = "Your student has been Updated successful";


                        try
                        {
                            db.SaveChanges();
                            Response.Redirect("ShowStudentDetails");
                        }
                        catch
                        {
                            lblMessage.Text = "data specified is not in proper format";
                            return;
                        }

                    }
                    else
                    {
                        Response.Redirect("ShowStudentDetails");
                    }
                }
                
            }
        }
    }
}