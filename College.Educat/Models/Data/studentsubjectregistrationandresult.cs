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
    
    public partial class studentsubjectregistrationandresult
    {
        public long studentid { get; set; }
        public int subjectid { get; set; }
        public string session { get; set; }
        public int term { get; set; }
        public double ca { get; set; }
        public double ca2 { get; set; }
        public double exam { get; set; }
        public int position { get; set; }
        public string grade { get; set; }
        public double classaverage { get; set; }
        public string teacherscomment { get; set; }
    
        public virtual student student { get; set; }
    }
}
