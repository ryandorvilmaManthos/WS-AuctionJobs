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
    
    public partial class ref_banque
    {
        public ref_banque()
        {
            this.t_carte_bancaire = new HashSet<t_carte_bancaire>();
        }
    
        public int id_banque { get; set; }
        public int fk_id_pays { get; set; }
        public string banq_nom { get; set; }
    
        public virtual ICollection<t_carte_bancaire> t_carte_bancaire { get; set; }
    }
}