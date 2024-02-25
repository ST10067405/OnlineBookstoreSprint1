using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpicBookstore.Models
{
    public class OrderItemModel
    {
        [Key]
        [Required]
        public int OrderItemId { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
        [Required]
        public double Price { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public OrderModel OrderModel { get; set; }

        [Required]
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public ItemModel ItemModel { get; set; }
    }
}