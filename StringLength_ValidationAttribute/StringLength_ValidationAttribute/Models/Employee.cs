using System.ComponentModel.DataAnnotations;
namespace StringLength_ValidationAttribute.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Must insert name!")]

        [StringLength(15,MinimumLength =4, ErrorMessage ="Name must be within 4 and 15 characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must select gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Insert age please !")]
        public int? Age { get; set; }
    }
}
