using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpicBookstore.Models
{
    public class CartModel
    {
        [Key]
        [Required]
        public int CartId { get; set; }
        [Range(0, double.MaxValue)]
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public ItemModel ItemModel { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}