using Instagram.Infrastructure.Data.DTOS;
using Instagram.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Instagram.Infrastructure.Data.Configurations
{
    public class FollowerConfiguration : IEntityTypeConfiguration<Follower>
    {
        private const string FollowerJsonPath = "../Instagram.Infrastructure/JSONS/followers.json";


        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.HasData(SeedFollowers());
        }

        private List<Follower> SeedFollowers()
        {
            List<Follower> result = new();
            List<FollowerDTO> followerDTOs = ReadJsonFollowers();

            foreach (FollowerDTO followerDTO in followerDTOs)
            {
                Follower follower = CastDTOToFollower(followerDTO);
                result.Add(follower);
            }

            return result;
        }


        private List<FollowerDTO> ReadJsonFollowers()
        {
            string text = File.ReadAllText(FollowerJsonPath);

            List<FollowerDTO>? followers = JsonSerializer.Deserialize<List<FollowerDTO>>(text);

            if (followers == null || followers.Count == 0)
            {
                throw new InvalidOperationException("Could not read followers json file.");
            }

            return followers;
        }





        private Follower CastDTOToFollower(FollowerDTO followerDTO)
        {
            return new Follower
            {
                Id = followerDTO.Id,
                FollowerId = followerDTO.FollowerId,
                FollowingId = followerDTO.FollowingId,
                CreatedAt = followerDTO.CreatedAt
            };
        }
    }
}