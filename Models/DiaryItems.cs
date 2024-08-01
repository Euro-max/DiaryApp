using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace DiaryApp.Models
{

    public class DiaryItems()
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =4, ErrorMessage ="Title should between 4 and 50 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}