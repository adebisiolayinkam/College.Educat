using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class AddSubject : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                string subject = Server.HtmlEncode(SubjectBox.Text);

                subject s = new subject
                {
                    subjectname = subject
                };


                db.subjects.Add(s);

                try
                {
                    db.SaveChanges();

                    
                    Response.Redirect("ShowSubject");

                }
                catch
                {
                    lblMessage.Text = "data specified is not in proper format";
                    return;
                }
            }
        }
    }
}