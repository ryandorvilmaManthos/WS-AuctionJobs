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
    
    public partial class DtoTAdresse
    {
    
        public int id_adresse { get; set; }
        public int id_ville { get; set; }
        public string adr_libelle { get; set; }
        public System.DateTime adr_date_modification { get; set; }
    
        public virtual ICollection<DtoRefUserAdress> ref_user_adress { get; set; }
        public virtual DtoTVilles t_villes { get; set; }
    }
}
