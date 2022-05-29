using System.ComponentModel.DataAnnotations;

namespace UserModule.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}