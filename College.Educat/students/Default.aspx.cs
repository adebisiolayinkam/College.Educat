﻿using College.Educat.Models.Data;
using College.Educat.Models.Report;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat.students
{
    public partial class Default : System.Web.UI.Page
    {
        EducatContext db = new EducatContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //PopulateSubject();
                PopulateClass();
                var setting = db.schoolsetups.FirstOrDefault();
                if (setting == null)
                {
                    Response.Redirect("AddSchoolInfo");
                }
                CurrentSessionLabel.Text = setting.currentsession;
                
            }
        }

        //public void PopulateSubject()
        //{
        //    var subj = from s in db.subjects select new { s.Id, s.subjectname };
        //    DropDownListSubject.DataSource = subj.ToList();
        //    DropDownListSubject.DataValueField = "Id";
        //    DropDownListSubject.DataTextField = "subjectname";
        //    DropDownListSubject.DataBind();
        //    DropDownListSubject.Items.Insert(0, "--Select Your Subjectname--");
        //}

                
        public void PopulateClass()
        {

            var Class = from c in db.classes select new { c.Id, c.classname };
            DropDownListClass.DataSource = Class.ToList();
            DropDownListClass.DataValueField = "Id";
            DropDownListClass.DataTextField = "classname";
            DropDownListClass.DataBind();
            DropDownListClass.Items.Insert(0, "--Select Your classname--");

        }




        protected void Btnshow_Click(object sender, EventArgs e)
        {
            var id = User.Identity.Name;
            var selectedStudent = long.Parse(id);
            var sstd = from s in db.students
                       where s.Id == selectedStudent
                       let theschool = db.schoolsetups.FirstOrDefault()
                       select new ReportSheet
                       {
                           Arm = s.Arm.armname,
                           CurrentClass = s.currentclassId.ToString(),
                           currentsession = s.currentsession,
                           currentterm = s.currentterm.ToString(),
                           dob = s.dob,
                           email = s.guardianemail,
                           FullName = s.lastname + " " + s.firstname + " " + s.othername,
                           Gender = s.gender,
                           locationaddress = theschool.locationaddress,
                           phoneno = theschool.phoneno,
                           picture = s.picture,
                           schoolname = theschool.schoolshortname,
                           StudentId = s.Id.ToString(),
                           logo = theschool.logo
                       };


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            LocalReport rpt = ReportViewer1.LocalReport;
            rpt.ReportPath = Server.MapPath("/Reports/r1.rdlc");

            ReportDataSource reportData = new ReportDataSource
            {
                Name = "ReportSheet",
                Value = sstd.ToList()
            };

            rpt.DataSources.Add(reportData);
            int cterm = int.Parse(sstd.ToList().FirstOrDefault().currentterm);
            var session = sstd.FirstOrDefault().currentsession;
            var rset = from r in db.studentsubjectregistrationandresults
                       where r.studentid == selectedStudent &&
                             r.session == session &&
                             r.term == cterm
                       select new ResultSet
                       {
                           ca = r.ca,
                           exam = r.exam,
                           classaverage = r.classaverage,
                           grade = r.grade,
                           session = r.session,
                           studentid = r.studentid.ToString(),
                           subjectid = r.subjectid,
                           SubjectName = db.subjects.FirstOrDefault(x => x.Id == r.subjectid).subjectname,
                           teacherscomment = r.teacherscomment,
                           termId = r.term,
                           position = r.position,
                       };

            reportData = new ReportDataSource
            {
                Name = "ResultSet",
                Value = rset.ToList()
            };
            rpt.DataSources.Add(reportData);

        }

        protected void DropDownListClassId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}