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
    
    public partial class DtoTCompetence
    {
        public int id_competence { get; set; }
        public int fk_id_category_com { get; set; }
        public string competence_nom { get; set; }
    
        public virtual ICollection<DtoRefCompetenceUser> ref_competence_user { get; set; }
        public virtual DtoTCategoryCompetence t_category_competence { get; set; }
        public virtual ICollection<DtoRefCompetenceAnnonce> ref_competence_annonce { get; set; }
        public virtual ICollection<DtoRefCompetenceGroup> ref_competence_group { get; set; }
    }
}
