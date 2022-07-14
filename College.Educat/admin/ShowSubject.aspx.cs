using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class ShowSubject : System.Web.UI.Page
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
                var sub = from s in db.subjects
                           select new 
                           {
                             s.subjectname
                           };
                GridView2.DataSource = sub.ToList().Take(5);
                GridView2.DataBind();

            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView2.Rows[index];
            string subjectid = (row.Cells[0].Text);
            if (e.CommandName == "edits")
            {
                Session["id"] = subjectid;
                Response.Redirect($"edits.aspx?id={subjectid}");
            }
            else if (e.CommandName == "delete")
            {

                using (EducatContext db = new EducatContext())
                {

                    long id = long.Parse(subjectid);
                    subject d = db.subjects.FirstOrDefault(x => x.Id == id);
                    try
                    {
                        db.subjects.Remove(d);
                        db.SaveChanges();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        string msgb = ex.Message;
                        Response.Write("<script>alert('An error occurre while deleting the subject');</script>");
                    }

                }
            }
        }

        protected void btnSubject_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSubject");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (EducatContext db = new EducatContext())
            {
                if (SubjectBox.Text == "")

                    LoadData();
                else
                {
                    var query = db.subjects.Where(x => x.subjectname == this.SubjectBox.Text).ToList();
                    this.GridView2.DataSource = query;
                    this.GridView2.DataBind();
                }

            }
        }
    }
}