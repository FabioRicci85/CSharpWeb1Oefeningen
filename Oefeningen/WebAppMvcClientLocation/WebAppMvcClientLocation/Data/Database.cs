using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Data
{
    
    public class Database
    { 
        public static List<Client> Clients { get; set; }
        public static List<Location> Locations { get; set; }

        public static void StartDatabase()
        {
            Clients = new List<Client>();
            Locations = new List<Location>();
            Clients.Add(new Client(1, 2, "Klant A"));
            Clients.Add(new Client(2, 1, "Klant B"));
            Locations.Add(new Location(1, "3500", "Hasselt"));
            Locations.Add(new Location(2, "3600", "Genk"));
        }
    }
}
