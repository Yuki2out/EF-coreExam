using Instagram.Infrastructure.Data.DTOS;
using Instagram.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Instagram.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        private const string UserJsonPath = "../Instagram.Infrastructure/JSONS/users.json";


        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(SeedUsers());
        }

        private List<User> SeedUsers()
        {
            List<User> result = new();
            List<UserDTO> userDTOs = ReadJsonUsers();

            foreach (UserDTO userDTO in userDTOs)
            {
                User user = CastDTOToUser(userDTO);
                result.Add(user);
            }

            return result;
        }


        private List<UserDTO> ReadJsonUsers()
        {
            string text = File.ReadAllText(UserJsonPath);

            List<UserDTO>? users = JsonSerializer.Deserialize<List<UserDTO>>(text);

            if (users == null || users.Count == 0)
            {
                throw new InvalidOperationException("Could not read user json file.");
            }

            return users;
        }





        private User CastDTOToUser(UserDTO userDTO)
        {
            return new User
            {
                Id = userDTO.Id,
                Username = userDTO.Username,
                Email = userDTO.Email,
                Avatar = userDTO.Avatar,
                Bio = userDTO.Bio,
                CreatedAt = userDTO.CreatedAt,
            };
        }
    }
}