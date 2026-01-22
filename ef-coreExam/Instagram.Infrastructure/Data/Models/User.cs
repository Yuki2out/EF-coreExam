using System.ComponentModel.DataAnnotations;
using static Instagram.Infrastructure.Data.Constants.DbConstants.UserConstants;

namespace Instagram.Infrastructure.Data.Models
{
    public class User
    {
        
        [Key]
        public string Id {get; set ;} = string.Empty;

        [Required]
        [MaxLength(UserNameMaxLenght)]
        public string Username {get; set ;} = string.Empty;

        [Required]
        [MaxLength(EmailMaxLenght)]
        public string Email {get; set ;} = string.Empty;
        
        public string Avatar {get; set ;} = string.Empty;

        [Required]
        [MaxLength(BioMaxLenght)]
        public string Bio {get; set ;} = string.Empty;
        public DateTime CreatedAt {get; set ;} = DateTime.Now;

        
    }
}