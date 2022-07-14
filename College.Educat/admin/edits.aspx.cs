using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class edits : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["id"] == null)
                    Response.Redirect("ShowSubject");

                long Id;
                Id = long.Parse(Session["id"].ToString());
                Loadstudentdata(Id);
            }
        }

        private void Loadstudentdata(long id)
        {

            var sub = db.subjects.FirstOrDefault(x => x.Id == id);
            if (sub != null)
            {
                SubjectBox.Text = sub.subjectname;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Validate();
            if (IsValid)
            {

                using (EducatContext db = new EducatContext())
                {
                    string subjectname = (string)Session["subjectname"];
                    var stu = db.subjects.FirstOrDefault(x => x.subjectname == subjectname);

                    if (stu != null)
                    {
                        stu.subjectname = Server.HtmlEncode(SubjectBox.Text);
                    }

                }

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
            else
            {
                Response.Redirect("ShowSubject");
            }
        }
    }
}