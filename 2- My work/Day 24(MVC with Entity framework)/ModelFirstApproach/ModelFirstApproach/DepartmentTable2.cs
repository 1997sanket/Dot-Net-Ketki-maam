//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstApproach
{
    using System;
    using System.Collections.Generic;
    
    public partial class DepartmentTable2
    {
        public DepartmentTable2()
        {
            this.EmployeeTable2 = new HashSet<EmployeeTable2>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<EmployeeTable2> EmployeeTable2 { get; set; }
    }
}