//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DCode.Data.DbContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public task()
        {
            this.approvedapplicants = new HashSet<approvedapplicant>();
            this.email_tracker = new HashSet<email_tracker>();
            this.taskapplicants = new HashSet<taskapplicant>();
            this.taskskills = new HashSet<taskskill>();
        }
    
        public int ID { get; set; }
        public int USER_ID { get; set; }
        public string PROJECT_NAME { get; set; }
        public string TASK_NAME { get; set; }
        public string PROJECT_WBS_Code { get; set; }
        public string TYPE { get; set; }
        public Nullable<int> TASK_TYPE_ID { get; set; }
        public Nullable<int> OFFERING_ID { get; set; }
        public string DETAILS { get; set; }
        public Nullable<int> HOURS { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<bool> GIFTS { get; set; }
        public Nullable<System.DateTime> ONBOARDING_DATE { get; set; }
        public int SERVICE_LINE_ID { get; set; }
        public Nullable<System.DateTime> DUE_DATE { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> STATUS_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_ON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<approvedapplicant> approvedapplicants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<email_tracker> email_tracker { get; set; }
        public virtual offering offering { get; set; }
        public virtual service_line service_line { get; set; }
        public virtual task_type task_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taskapplicant> taskapplicants { get; set; }
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taskskill> taskskills { get; set; }
    }
}
