namespace WebAppMvcClientLocation.Models
{
    public class ClientLocation
    {
        public string ClientName { get; set; }
        public string City { get; set; }

        public IEnumerable<ClientLocation> Overview()
        {
            var cl = Data.Database.Clients.Select(x => new ClientLocation { ClientName = x.ClientName, City = Data.Database.Locations.Where(y => y.LocationId == x.LocationId).FirstOrDefault().City });

            return cl;
        }
    }
}
