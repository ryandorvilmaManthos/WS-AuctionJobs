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
    
    public partial class t_recompense
    {
        public t_recompense()
        {
            this.t_recompense_user = new HashSet<t_recompense_user>();
        }
    
        public int id_recompense { get; set; }
        public string recompense_nom { get; set; }
        public string recompense_description { get; set; }
        public double recompense_credit { get; set; }
        public double recompense_xp { get; set; }
        public int recompense_type_user { get; set; }
    
        public virtual t_type_user t_type_user { get; set; }
        public virtual ICollection<t_recompense_user> t_recompense_user { get; set; }
    }
}
