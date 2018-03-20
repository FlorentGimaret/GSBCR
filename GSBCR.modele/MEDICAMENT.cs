//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSBCR.modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICAMENT
    {
        public MEDICAMENT()
        {
            this.LesEchantillonsOfferts = new HashSet<OFFRIR>();
            this.LesRapports2 = new HashSet<RAPPORT_VISITE>();
            this.LesRapports1 = new HashSet<RAPPORT_VISITE>();
        }
    
        public string MED_DEPOTLEGAL { get; set; }
        public string MED_NOMCOMMERCIAL { get; set; }
        public string FAM_CODE { get; set; }
        public string MED_COMPOSITION { get; set; }
        public string MED_EFFETS { get; set; }
        public string MED_CONTREINDIC { get; set; }
        public Nullable<float> MED_PRIXECHANTILLON { get; set; }
    
        public virtual FAMILLE LaFamille { get; set; }
        public virtual ICollection<OFFRIR> LesEchantillonsOfferts { get; set; }
        public virtual ICollection<RAPPORT_VISITE> LesRapports2 { get; set; }
        public virtual ICollection<RAPPORT_VISITE> LesRapports1 { get; set; }
    }
}
