using College.Educat.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.admin
{
    public partial class AddParent : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PopulateState();
              ScholIDField.Value = db.schoolsetups.FirstOrDefault().Id.ToString();

            }
        }

        public void PopulateState()
        {

            var st = from s in db.states select new { s.Id, s.statename };
            StateDropDownList.DataSource = st.ToList();
            StateDropDownList.DataValueField = "Id";
            StateDropDownList.DataTextField = "statename";
            StateDropDownList.DataBind();
            StateDropDownList.Items.Insert(0, "--Select Your State--");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                string pname = Server.HtmlEncode(ParentBox.Text),
                      pphone = Server.HtmlEncode(ParentPhonenoBox.Text),
                      pemail = Server.HtmlEncode(ParentEmailBox.Text),
                      paddress = Server.HtmlEncode(ParentHomeAddressBox.Text),
                      pcity = Server.HtmlEncode(CityBox.Text),
                      psate = Server.HtmlEncode(StateDropDownList.SelectedValue),
                      palternative = Server.HtmlEncode(AlternativePhoneNoBox.Text);

                parent p = new parent
                {
                    ParentNames = pname,
                    parentphoneno = pphone,
                    parentemailaddress = pemail,
                    homeaddress = paddress,
                    city = pcity,
                    state = int.Parse(psate),
                    alternativephoneno = palternative,
                    schoolid = int.Parse(ScholIDField.Value)
                };
                db.parents.Add(p);

                try
                {
                    db.SaveChanges();

                    //Response.Write("<script>alert('data Save Successfully');</script>");
                    Response.Redirect("~/Default.aspx");

                }
                catch
                {
                    lblMessage.Text = "data specified is not in proper format";
                    return;
                }
            }
            ParentBox.Text = "";
            ParentEmailBox.Text = "";
            ParentPhonenoBox.Text = "";
            ParentHomeAddressBox.Text = "";
            CityBox.Text = "";
        }
    }
}