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
    
    public partial class t_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_group()
        {
            this.ref_competence_group = new HashSet<ref_competence_group>();
            this.t_member_group = new HashSet<t_member_group>();
        }
    
        public int id_group { get; set; }
        public int fk_id_user_admin { get; set; }
        public string group_nom { get; set; }
        public string group_description { get; set; }
        public System.DateTime group_create { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ref_competence_group> ref_competence_group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_member_group> t_member_group { get; set; }
    }
}
