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
    
    public partial class t_pays
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_pays()
        {
            this.t_regions = new HashSet<t_regions>();
        }
    
        public int id_pays { get; set; }
        public Nullable<short> pays_code { get; set; }
        public string pays_alpha2 { get; set; }
        public string pays_alpha3 { get; set; }
        public string pays_nom_fr_fr { get; set; }
        public string pays_nom_en_gb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_regions> t_regions { get; set; }
    }
}
