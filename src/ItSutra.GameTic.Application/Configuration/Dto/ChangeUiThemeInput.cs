using System.ComponentModel.DataAnnotations;

namespace ItSutra.GameTic.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
