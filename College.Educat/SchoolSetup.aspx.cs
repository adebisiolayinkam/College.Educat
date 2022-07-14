using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat
{
    public partial class SchoolSetup : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {

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
                string sname = Server.HtmlEncode(SchoolBox.Text),
                      laddress = Server.HtmlEncode(LocationBox.Text),
                      email = Server.HtmlEncode(EmailBox.Text),
                      phone = Server.HtmlEncode(PhoneBox.Text),
                      csession = Server.HtmlEncode(CurrentSessionBox.Text),
                      cterm = Server.HtmlEncode (DropDownListCurrentTerm.Text),
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
                    email=email,
                    phoneno=phone,
                    currentsession = csession,
                    currentterm= int.Parse(cterm),
                    schoolshortname= sshortname,
                    cascore = double.Parse(ca),
                    examscore = double.Parse(exam)

                };


                db.schoolsetups.Add(sch);
                db.SaveChanges();
               

            }
        }
    }
}