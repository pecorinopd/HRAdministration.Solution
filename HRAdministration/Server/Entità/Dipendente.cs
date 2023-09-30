using System.ComponentModel.DataAnnotations.Schema;

namespace HRAdministration.Server.Entità
{
    public class Dipendente
    {
        public int DipendenteID { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? CodiceFiscale { get; set; }
        public int SedeID { get; set; }
        public string? Contratto { get; set; }
        public string? HardSkills { get; set; }
        public string? SoftSkills { get; set; }
        public string? TitoliStudio { get; set; }

        public Sede? SedeNavigation { get; set; } = null;
        public Contratto? ContrattoNavigation { get; set; } = null;
        public HardSkill? HardSkillNavigation { get; set; } = null;
        public SoftSkill? SoftSkillNavigation { get; set; } = null;
        public TitoloStudio? TitoloStudioNavigation { get; set; } = null;
    }
    
}
