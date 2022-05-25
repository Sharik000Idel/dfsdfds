//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Tickets = new HashSet<Tickets>();
            this.Personnal = new HashSet<Personnal>();
        }
    
        public int ID_flight { get; set; }
        public int place_of_departure { get; set; }
        public int landing_place { get; set; }
        public System.DateTime departure_time { get; set; }
        public System.DateTime boarding_time { get; set; }
        public Nullable<int> number_of_passengers { get; set; }
        public Nullable<int> cost { get; set; }
        public int ID_plane { get; set; }
    
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
        public virtual Plane Plane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnal> Personnal { get; set; }
    }
}
