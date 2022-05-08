using System.ComponentModel.DataAnnotations;

namespace RequiredValidationAttribute.Models
{
    public class Employee
    {   
        [Required(ErrorMessage ="Must insert name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must select gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Insert age please !")]
        public int? Age { get; set; }
    }
}
