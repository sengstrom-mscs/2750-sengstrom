//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInfoEx3AConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enrollment()
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
        }
    
        public int Id { get; set; }
        public GradeTypesEnum GradeType { get; set; }
        public GradesEnum Grade { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Section Section { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignmentGrade> AssignmentGrades { get; set; }
    }
}
