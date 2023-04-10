using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class AddSchoolInfo : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var SCH = db.schoolsetups.FirstOrDefault();
                if (SCH != null)
                {
                    SchoolBox.Text = SCH.schoolname;
                    LocationBox.Text = SCH.locationaddress;
                    EmailBox.Text = SCH.email;
                    PhoneBox.Text = SCH.phoneno;
                    CurrentSessionBox.Text = SCH.currentsession;
                    DropDownListCurrentTerm.SelectedValue = SCH.currentterm.ToString();
                    SchoolshortnameBox.Text = SCH.schoolshortname;
                    CascoreBox.Text = SCH.cascore.ToString();
                    ExamBox.Text =  SCH.examscore.ToString();
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                string sname = Server.HtmlEncode(SchoolBox.Text),
                      laddress = Server.HtmlEncode(LocationBox.Text),
                      email = Server.HtmlEncode(EmailBox.Text),
                      phone = Server.HtmlEncode(PhoneBox.Text),
                      csession = Server.HtmlEncode(CurrentSessionBox.Text),
                      cterm = Server.HtmlEncode(DropDownListCurrentTerm.Text),
                      sshortname = Server.HtmlEncode(SchoolshortnameBox.Text),
                      ca = Server.HtmlEncode(CascoreBox.Text),
                      exam = Server.HtmlEncode(ExamBox.Text);

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

                schoolsetup sch = new schoolsetup
                {
                    logo = imgbyte,
                    schoolname = sname,
                    locationaddress = laddress,
                    email = email,
                    phoneno = phone,
                    currentsession = csession,
                    currentterm = int.Parse(cterm),
                    schoolshortname = sshortname,
                    cascore = double.Parse(ca),
                    examscore = double.Parse(exam)

                };

                var sh = db.schoolsetups.FirstOrDefault();
                if (sh == null)
                {
                    db.schoolsetups.Add(sch);
                }
                else
                {
                    sh.currentsession = csession;
                    sh.currentterm = int.Parse(cterm);
                    sh.cascore = double.Parse(ca);
                    sh.examscore = double.Parse(exam);
                    sh.schoolshortname = sshortname;
                    sh.email = email;
                    sh.phoneno = phone;
                    sh.schoolname = sname;
                    sh.logo = imgbyte;
                    sh.locationaddress = laddress;
                }
                
                try
                {
                    db.SaveChanges();

                    Response.Write("<script>alert('data Save Successfully');</script>");
                    Response.Redirect("~/Default.aspx");

                }
                catch
                {
                    lblMessage.Text = "data specified is not in proper format";
                    return;
                }

            }
            SchoolBox.Text = "";
            LocationBox.Text = "";
            EmailBox.Text = "";
            PhoneBox.Text = "";
            CurrentSessionBox.Text = "";
            DropDownListCurrentTerm.Text = "";
            SchoolshortnameBox.Text = "";
            CascoreBox.Text = "";
            ExamBox.Text = "";

        }
    }
}