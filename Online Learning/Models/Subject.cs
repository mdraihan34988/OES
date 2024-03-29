//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Learning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            this.MyMaterials = new HashSet<MyMaterial>();
            this.Registrations = new HashSet<Registration>();
        }
    
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string SubjectType { get; set; }
        public double Price { get; set; }
        public int StudentCount { get; set; }
        public int TeacherId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyMaterial> MyMaterials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
