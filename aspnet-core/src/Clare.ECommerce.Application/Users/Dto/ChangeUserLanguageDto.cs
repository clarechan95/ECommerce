using System.ComponentModel.DataAnnotations;

namespace Clare.ECommerce.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}