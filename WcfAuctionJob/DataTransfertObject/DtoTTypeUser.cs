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
    
    public partial class DtoTTypeUser
    {
        public int id_typeuser { get; set; }
        public string typeuser_nom { get; set; }
    
        public virtual ICollection<DtoTRecompense> t_recompense { get; set; }
        public virtual ICollection<DtoTUserInfo> t_user_info { get; set; }
    }
}
