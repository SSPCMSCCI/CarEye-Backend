//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace carsharingbackend.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class component
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public component()
        {
            this.notifications = new HashSet<notification>();
        }
    
        public int id { get; set; }
        public int idCar { get; set; }
        public string name { get; set; }
        public string rfidTicketCode { get; set; }
        public bool isThere { get; set; }
        public bool active { get; set; }
    
        [Newtonsoft.Json.JsonIgnore] public virtual car car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Newtonsoft.Json.JsonIgnore] public virtual ICollection<notification> notifications { get; set; }
    }
}
