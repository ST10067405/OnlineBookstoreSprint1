using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpicBookstore.Models
{
    public class CartModel
    {
        [Key]
        [Required]
        public int CartId { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public ItemModel ItemModel { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}