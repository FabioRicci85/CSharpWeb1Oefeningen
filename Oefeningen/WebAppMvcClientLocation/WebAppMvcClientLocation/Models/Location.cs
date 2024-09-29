using System.ComponentModel.DataAnnotations;
namespace WebAppMvcClientLocation.Models
{
    public class Location
    {
        
        public int? LocationId { get; set; }
        [Required (ErrorMessage = "The PostCode field is required")]
        public string? PostCode { get; set; }
        [Required]
        public string? City { get; set; }

        public Location()
        {
            LocationId = -1;
            PostCode = string.Empty;
            City = string.Empty;
        }

        public Location(int locationId, string postCode, string city)
        {
            LocationId = locationId;
            PostCode = postCode;
            City = city;
        }
    }
}
