using System.ComponentModel.DataAnnotations;

namespace Sianca.Olh.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}