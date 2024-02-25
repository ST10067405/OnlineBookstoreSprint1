using System.ComponentModel.DataAnnotations;

namespace EpicBookstore.Models
{
    public class OrderModel
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public DateOnly OrderDate { get; set; }
        [Required]
        public double TotalPrice { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}