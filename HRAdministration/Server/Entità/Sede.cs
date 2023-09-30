namespace HRAdministration.Server.Entità
{
    public class Sede
    {
        public int SedeID { get; set; }
        public string? Descrizione { get; set;}
        public string? Indirizzo { get; set; }
        public string? RecapitoTelefonico { get; set; }
        public string? EmailSede { get; set; }
        public string? Referente { get; set; }

        public virtual ICollection<Dipendente> Dipendenti { get; set; } = new List<Dipendente>();

    }
}
