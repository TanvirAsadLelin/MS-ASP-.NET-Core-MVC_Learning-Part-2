using System.ComponentModel.DataAnnotations;

namespace Range_ValidationAttribute.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter age!")]
        [Range(18,60 , ErrorMessage ="Age between 18 to 60!")]
        public int Age { get; set; }
    }
}
