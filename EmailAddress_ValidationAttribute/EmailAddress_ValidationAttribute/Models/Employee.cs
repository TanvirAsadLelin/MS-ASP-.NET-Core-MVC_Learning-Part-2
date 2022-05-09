using System.ComponentModel.DataAnnotations;
namespace EmailAddress_ValidationAttribute.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Must enter email address!")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
