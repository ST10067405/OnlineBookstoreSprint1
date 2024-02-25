using System.ComponentModel.DataAnnotations;

namespace EpicBookstore.Models
{
    public class SearchLogModel
    {
        [Key]
        [Required]
        public string LogId { get; set; }
        [Required]
        public string SearchTerm { get; set; }
        [Required]
        public DateTime SearchDateTime { get; set; }
        [Required]
        public string UserId { get; set; }

    }
}