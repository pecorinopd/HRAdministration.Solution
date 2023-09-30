namespace HRAdministration.Server.Entità
{
    public class Candidato
    {
        public int CandidatoID { get; set; }
        public string? Nome  { get; set; }
        public string? Cognome { get; set; }
        public string? RecapitoTelefonico { get; set; }
        public string? CodiceFiscale { get; set; }
        public string? StatoNascita { get; set; }
        public string? ProvinciaNascita { get; set; }
        public string? ComuneNascita { get; set; }
        public string? Residenza { get; set; }
        public string? Email { get; set; }
        public string? SoftSkills { get; set; }
        public string? HardSkills { get; set; }
        public string? TitoliStudio { get; set;}
        public string? TipoContratto { get; set; }
    }
}
