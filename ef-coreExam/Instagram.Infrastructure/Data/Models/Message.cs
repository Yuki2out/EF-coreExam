using System.ComponentModel.DataAnnotations;
using static Instagram.Infrastructure.Data.Constants.DbConstants.MessageConstants;
using System.ComponentModel.DataAnnotations.Schema;
using  Instagram.Infrastructure.Data.Constants;

namespace Instagram.Infrastructure.Data.Models
{
    public class Message
    {
        
        [Key]
        public string Id {get; set ;} = string.Empty;

        [Required]
        [ForeignKey(nameof(SenderId))]
        public string SenderId {get; set ;} = string.Empty;

        [Required]
        [ForeignKey(nameof(ReciverId))]
        public string ReciverId {get; set ;} = string.Empty;

        [Required]
        [MaxLength(ContentMaxLenght)]
        public string Content {get; set ;} = string.Empty;

        [Required]
        public DateTime CreatedAt {get; set ;} = DateTime.Now;

        [Required]
        public Boolean Read {get; set ;} = false;


    }
}