using System.ComponentModel.DataAnnotations;

namespace EpicBookstore.Models
{
    public class AddressModel
    {
        [Key]
        [Required]
        public int AddressId { get; set; }
        [Required]
        public string Country {  get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
