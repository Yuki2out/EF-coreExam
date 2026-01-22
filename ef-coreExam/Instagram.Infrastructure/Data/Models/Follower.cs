using System.ComponentModel.DataAnnotations;
using  Instagram.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Infrastructure.Data.Models
{
    public class Follower
    {
        
        [Key]
        public string Id {get; set ;} = string.Empty;
        
        [Required]
        [ForeignKey(nameof(FollowerId))]
        public string FollowerId {get; set ;} = string.Empty;

        [Required]
        [ForeignKey(nameof(FollowingId))]
        public string FollowingId {get; set ;} = string.Empty;

        [Required]
        public DateTime CreatedAt {get; set ;} = DateTime.Now;

    }
}