using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Instagram.Infrastructure.Data.DTOS
{
    public class MessageDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("senderId")]
        public string SenderId { get; set; } = string.Empty;

        [JsonPropertyName("renderId")]
        public string RenderId { get; set; } = string.Empty;

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("read")]
        public Boolean Read { get; set; }
    }

}