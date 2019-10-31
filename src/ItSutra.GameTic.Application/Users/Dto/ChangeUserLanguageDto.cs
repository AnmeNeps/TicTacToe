using System.ComponentModel.DataAnnotations;

namespace ItSutra.GameTic.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}