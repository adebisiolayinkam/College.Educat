using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Educat.Models.Report
{
    public class ReportSheet
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string schoolname { get; set; }
        public string locationaddress { get; set; }
        public byte[] logo { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
        public string currentsession { get; set; }
        public string currentterm { get; set; }
        public DateTime dob { get; set; }
        public byte[] picture { get; set; }
        public string Arm { get; set; }
        public string CurrentClass { get; set; }

    }
}