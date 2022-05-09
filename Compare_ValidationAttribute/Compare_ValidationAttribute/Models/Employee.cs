using System.ComponentModel.DataAnnotations;
namespace Compare_ValidationAttribute.Models
{
    public class Employee
    {
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Use Uppercase, Lowercase, Numbers, Symbols & At least 8 Characters.")]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage ="Confirm password not match with password!")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        
    }
}
