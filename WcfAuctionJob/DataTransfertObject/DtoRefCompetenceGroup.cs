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

    public partial class DtoRefCompetenceGroup
    {
        public int id_competence { get; set; }
        public int id_group { get; set; }
        public short is_actually { get; set; }
    
        public virtual DtoTCompetence t_competence { get; set; }
        public virtual DtoTGroup t_group { get; set; }
    }
}
