//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT_main
{
    using System;
    using System.Collections.Generic;
    
    public partial class przedmioty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public przedmioty()
        {
            this.plan_zajec = new HashSet<plan_zajec>();
            this.prowadzacy_przedmiot = new HashSet<prowadzacy_przedmiot>();
            this.zapisani_na_przedmiot = new HashSet<zapisani_na_przedmiot>();
        }
    
        public int ID { get; set; }
        public string nazwa { get; set; }
        public Nullable<bool> aktywny { get; set; }
        public string typ { get; set; }
        public Nullable<int> kierunek { get; set; }
        public Nullable<int> prowadzacy_id { get; set; }
    
        public virtual kadra kadra { get; set; }
        public virtual kierunki kierunki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plan_zajec> plan_zajec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prowadzacy_przedmiot> prowadzacy_przedmiot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zapisani_na_przedmiot> zapisani_na_przedmiot { get; set; }
    }
}
