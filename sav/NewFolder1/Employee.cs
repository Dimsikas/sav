//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sav.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Id_employee { get; set; }
        public string FIO_employe { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Id_role { get; set; }
        public string Attendance { get; set; }
        public string Schedule { get; set; }
        public Nullable<System.DateTime> Release_date { get; set; }
        public Nullable<decimal> Salary { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
