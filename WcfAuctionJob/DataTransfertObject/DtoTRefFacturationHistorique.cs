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
    
    public partial class DtoTRefFacturationHistorique
    {
        public int id_facturation { get; set; }
        public Nullable<int> fk_id_statut_facturation { get; set; }
        public System.DateTime date_modification { get; set; }
    
        public virtual DtoRefStatusFacture ref_status_facture { get; set; }
        public virtual ICollection<DtoTUser> t_user { get; set; }
    }
}
