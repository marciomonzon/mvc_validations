using System.ComponentModel.DataAnnotations;

namespace MvcValidationsExample.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Email length can't be more than 200.")]
        public string Email { get; set; }
    }
}
