using MVCTagHelper.Models;

namespace MVCTagHelper.ViewModels
{
    public class MedewerkerCard
    {
        public int MedewerkerId { get; set; }
        public string MedewerkerNaam { get; set; }
        public string AfdelingNaam { get; set; }
        public MedewerkerCard(Medewerker medewerker)
        {
            MedewerkerId = medewerker.MedewerkerId;
            MedewerkerNaam = $"{medewerker.Voornaam} {medewerker.Naam}";
            AfdelingNaam = medewerker.Afdeling.AfdelingNaam;

        }
    }
    
}
