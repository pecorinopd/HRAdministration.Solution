namespace HRAdministration.Server.Entità
{
    public class Colloquio
    {
        public int ColloquioID { get; set; }
        public string? HR { get; set; }
        public string?  TipologiaColloquio { get; set; }
        public string? ReferenteTecnico { get; set; }
        public string? SedeColloquio { get; set; }
        public string? Candidato { get; set; }
        public int Valutazione { get; set; }
        public string? Note { get; set; }
    }
}
