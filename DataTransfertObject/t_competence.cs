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
    
    public partial class t_competence
    {
        public t_competence()
        {
            this.ref_competence_user = new HashSet<ref_competence_user>();
            this.ref_competence_annonce = new HashSet<ref_competence_annonce>();
            this.ref_competence_group = new HashSet<ref_competence_group>();
        }
    
        public int id_competence { get; set; }
        public int fk_id_category_com { get; set; }
        public string competence_nom { get; set; }
    
        public virtual ICollection<ref_competence_user> ref_competence_user { get; set; }
        public virtual t_category_competence t_category_competence { get; set; }
        public virtual ICollection<ref_competence_annonce> ref_competence_annonce { get; set; }
        public virtual ICollection<ref_competence_group> ref_competence_group { get; set; }
    }
}