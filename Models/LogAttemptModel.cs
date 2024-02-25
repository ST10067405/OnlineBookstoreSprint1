using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpicBookstore.Models
{
    public class LogAttemptModel
    {
        [Key]
        [Required]
        public int AttemptId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime AttemptDateTime { get; set; }
        [Required]
        public bool SuccessFlag { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}