namespace MVCTagHelper.Models
{
    public class Medewerker
    {
        public int MedewerkerId { get; set; }
        public int AfdelingId { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public Afdeling? Afdeling { get; set; }
    }
}
