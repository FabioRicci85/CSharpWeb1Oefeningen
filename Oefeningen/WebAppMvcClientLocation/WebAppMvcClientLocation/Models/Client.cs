using System.ComponentModel.DataAnnotations;

namespace WebAppMvcClientLocation.Models
{
    public class Client
    {
        [Required]
        public int? ClientId { get; set; }
        [Required]
        public int? LocationId { get; set; }
        [Required(ErrorMessage = "ClientName is required!")]
        public string? ClientName { get; set; }

        public Client()
        {
            ClientId = -1;
            LocationId = -1;
            ClientName = string.Empty;
        }

        public Client(int clientId, int locationId, string name)
        {
            ClientId = clientId;
            LocationId = locationId;
            ClientName = name;
        }
    }
}
