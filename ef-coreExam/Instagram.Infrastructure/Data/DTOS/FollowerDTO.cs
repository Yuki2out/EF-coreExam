using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Instagram.Infrastructure.Data.DTOS
{
    public class FollowerDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("followerId")]
        public string FollowerId { get; set; } = string.Empty;

        [JsonPropertyName("followingId")]
        public string FollowingId { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }

}