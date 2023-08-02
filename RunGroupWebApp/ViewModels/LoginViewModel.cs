using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email Adddress")]
        [Required(ErrorMessage = "Email address is requared")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
