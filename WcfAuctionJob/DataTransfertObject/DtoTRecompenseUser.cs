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

    public partial class DtoTRecompenseUser
    {
        public int id_recompense_user { get; set; }
        public int fk_id_user { get; set; }
        public Nullable<int> fk_id_recompense { get; set; }
        public System.DateTime date_obtention { get; set; }
    
        public virtual DtoTRecompense t_recompense { get; set; }
        public virtual DtoTUser t_user { get; set; }
    }
}
