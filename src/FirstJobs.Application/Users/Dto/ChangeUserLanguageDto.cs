using System.ComponentModel.DataAnnotations;

namespace FirstJobs.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}