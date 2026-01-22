using Instagram.Infrastructure.Data.DTOS;
using Instagram.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Instagram.Infrastructure.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private const string PostJsonPath = "../Instagram.Infrastructure/JSONS/posts.json";


        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(SeedPosts());
        }

        private List<Post> SeedPosts()
        {
            List<Post> result = new();
            List<PostDTO> postDTOs = ReadJsonPosts();

            foreach (PostDTO postDTO in postDTOs)
            {
                Post post = CastDTOToPost(postDTO);
                result.Add(post);
            }

            return result;
        }


        private List<PostDTO> ReadJsonPosts()
        {
            string text = File.ReadAllText(PostJsonPath);

            List<PostDTO>? posts = JsonSerializer.Deserialize<List<PostDTO>>(text);

            if (posts == null || posts.Count == 0)
            {
                throw new InvalidOperationException("Could not read postp json file.");
            }

            return posts;
        }





        private Post CastDTOToPost(PostDTO postDTO)
        {
            return new Post
            {
                Id = postDTO.Id,
                UserId = postDTO.UserId,
                Content = postDTO.Content,
                Image = postDTO.Image,
                CreatedAt = postDTO.CreatedAt
               
            };
        }
    }
}