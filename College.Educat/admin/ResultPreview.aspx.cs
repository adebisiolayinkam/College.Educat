using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class ResultPreview : System.Web.UI.Page
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

    }
}