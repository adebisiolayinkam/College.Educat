using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Educat.Models
{

    public class ReportScores
    {
        public long studentid { get; set; }
        public int subjectid { get; set; }
        public string session { get; set; }
        public int term { get; set; }
        public double ca { get; set; }
        public double exam { get; set; }
        public int position { get; set; }
        public string grade { get; set; }
        public double classaverage { get; set; }
        public string teacherscomment { get; set; }
        public string SubjectName { get; set; }
    }

    public class ReportCard
    {
        public long StudentId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string schoolname { get; set; }
        public string locationaddress { get; set; }
        public byte[] logo { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
        public string currentsession { get; set; }
        public int currentterm { get; set; }
        public DateTime dob { get; set; }
        public byte[] picture { get; set; }
        public string Arm { get; set; }
        public string CurrentClass { get; set; }
    }
    public class ReportSheet
    {
        public long StudentId { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string othername { get; set; }
        public string FullName
        {
            get
            {
                return $"{firstname} {othername}, {lastname.ToUpper()}";
            }
        }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string currentclass { get; set; }
        public string currentsession { get; set; }
        public int currentterm { get; set; }
        public string Arm { get; set; }
        public byte[] picture { get; set; }
        public string Schoolname { get; set; }
        public string ScholAddress { get; set; }
        public byte[] SchoolLogo { get; set; }
        public string SchoolEmail { get; set; }
        public string ShoolPhoneno { get; set; }
        public List<MySubjects> Subjects{ get; set; }
        public string principalscomment { get; set; }
        public int noofattendance { get; set; }
        public string classteachercomments { get; set; }
    }

    public class MySubjects
    {
        public long Studentid { get; set; }
        public string SubjectName { get; set; }
        public double ca { get; set; }
        public double exam { get; set; }
        public int position { get; set; }
        public string grade { get; set; }
        public double classaverage { get; set; }
        public int subjectid { get; set; }
        
    }
}

