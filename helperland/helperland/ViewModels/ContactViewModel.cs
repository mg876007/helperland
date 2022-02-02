using System.ComponentModel.DataAnnotations;

namespace helperland.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please Enter Mobile Number")]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please Enter Subject")]
        public string? Subject { get; set; }
        [Required(ErrorMessage = "Please Enter Message")]
        public string? Message { get; set; }
    }
}
