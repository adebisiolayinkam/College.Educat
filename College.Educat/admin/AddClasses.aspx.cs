using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class AddClasses : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                ScholIDField.Value = db.schoolsetups.FirstOrDefault().Id.ToString();

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                string cname = Server.HtmlEncode(ClassBox.Text),
                      next = Server.HtmlEncode(NextClassBox.Text),
                      classtyp = Server.HtmlEncode(ClasstypeBox.Text);
                int g = int.Parse(next);
                var s = new Models.Data.@class

                {
                    classname = cname,
                    nextclass = g,
                    classtype = classtyp,
                    schoolid = int.Parse(ScholIDField.Value)
                };
                db.classes.Add(s);
                
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
            ClassBox.Text = "";
            NextClassBox.Text = "";
            ClasstypeBox.Text = "";
        }
    }
}
