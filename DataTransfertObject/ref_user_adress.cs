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
    
    public partial class ref_user_adress
    {
        public ref_user_adress()
        {
            this.t_user_info = new HashSet<t_user_info>();
        }
    
        public int fk_user_id { get; set; }
        public int fk_adresse_id { get; set; }
        public int id_ref_id { get; set; }
    
        public virtual t_adresse t_adresse { get; set; }
        public virtual t_user t_user { get; set; }
        public virtual ICollection<t_user_info> t_user_info { get; set; }
    }
}
