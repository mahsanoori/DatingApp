using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage="مقداری وارد نمایید.")]
        public string Username { get; set; }

        [Required(ErrorMessage="مقداری وارد نمایید.")]
        public string Password { get; set; }
    }
}