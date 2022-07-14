using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using College.Educat.Models;

namespace College.Educat.admin
{
    public partial class AddStudent : System.Web.UI.Page
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
            }
        }

        private void LoadYears()
        {
            for (int i = DateTime.Now.AddYears(-10).Year; i <= DateTime.Now.Year ; i++)
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

        protected async void btnSubmit_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                string lname = Server.HtmlEncode(SurnameBox.Text),
                         fname = Server.HtmlEncode(FirstNameBox.Text),
                         oname = Server.HtmlEncode(OtherNameBox.Text),
                         sex = GenderDropDownList.SelectedValue,
                         curtclasId = DropDownListClassID.SelectedValue,
                         curtsesion = Server.HtmlEncode(CurrentSessionBox.Text),
                         curtterm = DropDownListCurrentTerm.Text,
                         arm = DropDownListArmId.SelectedValue,
                         guardname = Server.HtmlEncode(GuardianNameBox.Text),
                         guardphone = Server.HtmlEncode(GuardianPhoneNoBox.Text),
                         guardemail = Server.HtmlEncode(GuardianEmailBox.Text),
                         address = Server.HtmlEncode(HomeAddressBox.Text),
                         city = Server.HtmlEncode(CityBox.Text),
                         state = StateDropDownList.SelectedValue,
                         yrentry = DropDownListYEntry.Text;


                DateTime dob;
                bool valid = DateTime.TryParse(DobTextBox.Text, out dob);
                if (!IsValid)
                {
                    lblMessage.Text = "invalid date of birth";
                    return;
                }

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
                student std = new student
                {
                    city = city,
                    picture = imgbyte,
                    lastname = lname,
                    firstname = fname,
                    othername = oname,
                    gender = sex,
                    currentclassId = int.Parse(curtclasId),
                    currentsession = curtsesion,
                    currentterm = int.Parse(curtterm),
                    dob = dob,
                    armId = int.Parse(arm),
                    guardiannames = guardname,
                    guardianphoneno = guardphone,
                    guardianemail = guardemail,
                    homeaddress = address,
                    state = int.Parse(state),
                    yearofentry = int.Parse(yrentry),
                    graduated = false,
                    yearofgraduation = 0,
                    parentid = 192001

                };

                db.students.Add(std);

                try
                {
                    db.SaveChanges();

                    SiteUser create = new SiteUser()
                    {
                        DeleteFirst = false,
                        Email = "info@codeweb.com.ng",
                        Password = SurnameBox.Text.ToLower(),
                        PhoneNo = guardphone,
                        RoleName = "students",
                        UserName = std.Id.ToString()
                    };
                    await create.Create();
                    //Response.Write("<script>alert('data Save Successfully');</script>");
                    Response.Redirect("ShowStudentDetails", false);

                }
                catch (Exception ex)
                {
                    lblMessage.Text = "data specified is not in proper format" + ex.Message;
                    return;
                }
            }

            SurnameBox.Text = "";
            FirstNameBox.Text = "";
            OtherNameBox.Text = "";
            CurrentSessionBox.Text = "";
            GuardianNameBox.Text = "";
            GuardianPhoneNoBox.Text = "";
            GuardianEmailBox.Text = "";
            HomeAddressBox.Text = "";
            CityBox.Text = "";


        }
    }
}