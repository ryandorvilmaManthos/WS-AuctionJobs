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
    
    public partial class DtoRefStatusFacture
    {
    
        public int id_facture { get; set; }
        public string fact_nom { get; set; }
    
        public virtual ICollection<DtoTRefFacturationHistorique> t_ref_facturation_historique { get; set; }
    }
}
