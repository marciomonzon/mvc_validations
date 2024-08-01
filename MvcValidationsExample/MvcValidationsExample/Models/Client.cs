using MvcValidationsExample.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace MvcValidationsExample.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [ValidateName(ErrorMessage = "Name must not contain `@`")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
    }
}
