using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.Reports
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //144119141

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/r1.rdlc");
                //Customers dsCustomers = GetData("select top 20 * from customers");

                using(Models.Data.EducatContext db = new Models.Data.EducatContext())
                {
                    var schl = db.schoolsetups.FirstOrDefault();
                    var std = db.students.FirstOrDefault(x => x.Id == 144119141);
                    var subj = db.studentsubjectregistrationandresults.Where(x => x.studentid == 144119141 && x.session == schl.currentsession && x.term == schl.currentterm);
                    Models.ReportCard card = new Models.ReportCard
                    {
                        Arm = std.Arm.armname,
                        CurrentClass = std.@class.classname,
                        currentsession = schl.currentsession,
                        currentterm = schl.currentterm,
                        dob = std.dob,
                        FullName = std.firstname + " " + std.othername + " " + std.lastname.ToUpper(),
                        Gender = std.gender,
                        email = schl.email,
                        locationaddress = schl.locationaddress,
                        phoneno = schl.phoneno,
                        logo = schl.logo,
                        picture = std.picture,
                        schoolname = schl.schoolname,
                        StudentId = std.Id
                    };
                    List<Models.ReportCard> cards = new List<Models.ReportCard>();
                    cards.Add(card);
                    ReportDataSource datasource = new ReportDataSource("ReportSheet", cards);
                    List<Models.ReportScores> score = new List<Models.ReportScores>();
                    foreach(var s in subj)
                    {
                        score.Add(new Models.ReportScores
                        {
                            ca = s.ca,
                            classaverage = s.classaverage,
                            exam = s.exam,
                            grade = s.grade,
                            session = s.session,
                            position = s.position,
                            studentid = s.studentid,
                            subjectid = s.subjectid,
                            SubjectName = db.subjects.FirstOrDefault(x => x.Id == s.subjectid).subjectname,
                            term = s.term
                        });
                    }
                   // datasource = new ReportDataSource("Scores", score);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(datasource);

                }
               

            }
        }


    }
}