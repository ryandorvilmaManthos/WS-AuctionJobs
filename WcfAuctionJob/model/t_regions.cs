//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfAuctionJob.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_regions()
        {
            this.t_departement = new HashSet<t_departement>();
        }
    
        public int id_region { get; set; }
        public int id_pays { get; set; }
        public string region_nom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_departement> t_departement { get; set; }
        public virtual t_pays t_pays { get; set; }
    }
}
