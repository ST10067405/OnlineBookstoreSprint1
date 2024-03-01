using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpicBookstore.Models
{
    public class ItemModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string CoverImageUrl { get; set; }
    }
}