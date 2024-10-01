using System.ComponentModel.DataAnnotations;

namespace MVCModelValidation.Models
{
    public class TestData
    {
        public int? TestDataId { get; set; }
        [Required]
        [StringLength(10)]
        public string? TestText { get; set; }
        //[CustomDate]
        public DateTime? TestDate { get; set; }
    }
}
