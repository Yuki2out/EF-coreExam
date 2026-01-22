using System.ComponentModel.DataAnnotations;
using  Instagram.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Infrastructure.Data.Models
{
    public class Post
    {
        
        [Key]
        public string Id {get; set ;} = string.Empty;
        
        [ForeignKey(nameof(UserId))]
        public string UserId {get; set ;} = string.Empty;

        public string Content {get; set ;} = string.Empty;

        public string? Image {get; set ;} = string.Empty;

        public DateTime CreatedAt {get; set ;} = DateTime.Now;

    }
}