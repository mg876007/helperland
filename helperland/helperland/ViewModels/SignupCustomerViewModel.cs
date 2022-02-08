using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace helperland.ViewModels
{
    public class SignupCustomerViewModel
    {
        [Required(ErrorMessage ="Please enter your Firstname")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your Lastname")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [Display(Name ="Email Address")]
        [EmailAddress(ErrorMessage ="Enter a valid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your Mobile Number")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [Compare("ConfirmPassword",ErrorMessage ="Password Does not match")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]   
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your Password")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        
        [Display(Name ="Privacy Policy")]
        public bool PrivacyPolicy { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
