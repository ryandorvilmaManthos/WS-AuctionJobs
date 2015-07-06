using System;
using System.Collections.Generic;

namespace WcfAuctionJob.DataTransfertObject
{
    public class DtoTAnnonce
    {
        public int id_annonce { get; set; }
        public int fk_id_useradmin { get; set; }
        public Nullable<int> fk_id_user_win { get; set; }
        public Nullable<int> fk_id_statutannonce { get; set; }
        public Nullable<double> fk_id_category { get; set; }
        public double fk_id_adresse { get; set; }
        public string annonce_title { get; set; }
        public string annonce_subtittle { get; set; }
        public string annonce_description_mission { get; set; }
        public double annonce_prix { get; set; }
        public short annonce_validate { get; set; }
        public System.DateTime annonce_start { get; set; }
        public Nullable<System.DateTime> annonce_deadline { get; set; }
        public System.DateTime annonce_modification { get; set; }

        public virtual ICollection<DtoRefCompetenceAnnonce> ref_competence_annonce { get; set; }
        public virtual DtoTUser t_user { get; set; }
        public virtual DtoTUser t_user1 { get; set; }
        public virtual DtoTStatutAnnonce t_statut_annonce { get; set; }
        public virtual DtoTAnnonceProposition t_annonce_proposition { get; set; }    
    }
}