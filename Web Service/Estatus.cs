//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estatus
    {
        public Estatus()
        {
            this.tbl_log_vacaciones = new HashSet<LogVacaciones>();
            this.tbl_log_vacaciones1 = new HashSet<LogVacaciones>();
            this.tbl_vacaciones = new HashSet<Vacaciones>();
        }
    
        public int estatusid { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
    
        public virtual ICollection<LogVacaciones> tbl_log_vacaciones { get; set; }
        public virtual ICollection<LogVacaciones> tbl_log_vacaciones1 { get; set; }
        public virtual ICollection<Vacaciones> tbl_vacaciones { get; set; }
    }
}
