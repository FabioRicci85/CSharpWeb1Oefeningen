using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Data
{
    
    public class Database
    { 
        public static List<Client> Clients { get; set; }
        public static List<Location> Locations { get; set; }



        public static InsertResult AddClient(Client c)
        {
            var result = new InsertResult();
            if (Clients.Any(client => client.ClientId == c.ClientId))
            {
                result.Succeeded = false;
                result.Errors.Add("ClientId bestaat al.");
            }
            else
            {
                Clients.Add(c);
                result.Succeeded = true;
            }

            return result;
        }

        public static InsertResult AddLocation(Location l)
        {
            var result = new InsertResult();
            if (string.IsNullOrEmpty(l.City) || string.IsNullOrEmpty(l.PostCode))
            {
                result.Succeeded = false;
                result.Errors.Add("City en PostCode moeten mee gegeven worden.");
            }
            else
            {
                l.LocationId = Locations.Count + 1;
                Locations.Add(l);
                result.Succeeded = true;
            }

            return result;
        }

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
