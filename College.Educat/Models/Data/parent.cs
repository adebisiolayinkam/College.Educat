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
    
    public partial class parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parent()
        {
            this.students = new HashSet<student>();
        }
    
        public long ParentId { get; set; }
        public string ParentNames { get; set; }
        public string parentphoneno { get; set; }
        public string parentemailaddress { get; set; }
        public string homeaddress { get; set; }
        public string city { get; set; }
        public int state { get; set; }
        public string alternativephoneno { get; set; }
        public int schoolid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students { get; set; }
    }
}
