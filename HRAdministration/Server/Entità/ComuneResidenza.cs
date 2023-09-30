using System.ComponentModel.DataAnnotations.Schema;

namespace HRAdministration.Server.Entità
{
    public class ComuneResidenza
    {
        public int ComuneID { get; set; }
        public string?  Nome { get; set; }
        
        public string? Provincia { get; set; }

    }
}
