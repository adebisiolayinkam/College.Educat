//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace College.Educat.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class commentsonresult
    {
        public long studentid { get; set; }
        public int subjectid { get; set; }
        public string session { get; set; }
        public int term { get; set; }
        public string classteachercomments { get; set; }
        public string principalscomment { get; set; }
        public int noofattendance { get; set; }
        public double percentagescore { get; set; }
        public double cumulativeaverage { get; set; }
        public byte pryschomotorsports { get; set; }
        public byte pryschomotorhandwritingskills { get; set; }
        public byte pryschomotorhandriting { get; set; }
        public byte pryschomotorverbalfluency { get; set; }
        public byte pryschomotorsgames { get; set; }
        public byte pryschomotordrawingandpainting { get; set; }
        public byte affectiveareapunctuality { get; set; }
        public byte affectiveareaneatness { get; set; }
        public byte affectiveareapoliteness { get; set; }
        public byte affectiveareahonesty { get; set; }
        public byte affectiveareacooperationwithothers { get; set; }
        public byte affectivearealeadership { get; set; }
        public byte affectiveareahelpingothers { get; set; }
        public byte affectiveareaemotionalstability { get; set; }
        public byte affectiveareahealth { get; set; }
        public byte affectiveareaattitudetoschoolwork { get; set; }
        public byte affectiveareaattentiveness { get; set; }
        public byte affectiveareaperseverance { get; set; }
        public byte affectiveareaspeakinganfhandwriting { get; set; }
    
        public virtual student student { get; set; }
        public virtual subject subject { get; set; }
    }
}
