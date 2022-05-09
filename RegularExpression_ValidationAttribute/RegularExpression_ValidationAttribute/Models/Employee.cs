using System.ComponentModel.DataAnnotations;
namespace RegularExpression_ValidationAttribute.Models
{
    public class Employee
    {
       // string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
        [Required]  
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Use Uppercase, Lowercase, Numbers, Symbols & At least 8 Characters.")]
        public string Password { get; set; }
    }
}
