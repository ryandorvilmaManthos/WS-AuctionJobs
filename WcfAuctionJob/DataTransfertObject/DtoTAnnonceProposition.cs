//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfAuctionJob.DataTransfertObject
{
    using System;
    using System.Collections.Generic;

    public partial class DtoTAnnonceProposition
    {
        public int id_anno_proposition { get; set; }
        public int fk_id_user { get; set; }
        public int fk_id_annonce { get; set; }
        public string annopro_description { get; set; }
        public double annopro_prix { get; set; }
        public System.DateTime annopro_create { get; set; }
    
        public virtual DtoTAnnonce t_annonce { get; set; }
        public virtual DtoTUser t_user { get; set; }
    }
}
