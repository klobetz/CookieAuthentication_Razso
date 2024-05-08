using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model.ViewModel
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false,ErrorMessage ="A Login Név kitöltése kötelező")]
        public string? Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A Jelszó mező kitöltése kötelező")]
        public string? Password { get; set; }
    }
}
