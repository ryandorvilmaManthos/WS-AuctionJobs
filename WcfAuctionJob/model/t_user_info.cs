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
    
    public partial class t_user_info
    {
        public int id_fk_user { get; set; }
        public int fk_id_typeuser { get; set; }
        public Nullable<int> fk_id_adresse { get; set; }
        public Nullable<int> fk_id_level { get; set; }
        public double userinfo_exp { get; set; }
        public byte[] userinfo_image { get; set; }
        public System.DateTime userinfo_date_modfif { get; set; }
    
        public virtual ref_user_adress ref_user_adress { get; set; }
        public virtual t_level t_level { get; set; }
        public virtual t_type_user t_type_user { get; set; }
        public virtual t_user t_user { get; set; }
    }
}
