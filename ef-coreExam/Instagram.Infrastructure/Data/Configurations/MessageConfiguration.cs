using Instagram.Infrastructure.Data.DTOS;
using Instagram.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Instagram.Infrastructure.Data.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        private const string MessageJsonPath = "../Instagram.Infrastructure/JSONS/messages.json";


        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(SeedMessages());
        }

        private List<Message> SeedMessages()
        {
            List<Message> result = new();
            List<MessageDTO> messageDTOs = ReadJsonMessages();

            foreach (MessageDTO messageDTO in messageDTOs)
            {
                Message message = CastDTOToMessage(messageDTO);
                result.Add(message);
            }

            return result;
        }


        private List<MessageDTO> ReadJsonMessages()
        {
            string text = File.ReadAllText(MessageJsonPath);

            List<MessageDTO>? messages = JsonSerializer.Deserialize<List<MessageDTO>>(text);

            if (messages == null || messages.Count == 0)
            {
                throw new InvalidOperationException("Could not read messages json file.");
            }

            return messages;
        }





        private Message CastDTOToMessage(MessageDTO messageDTO)
        {
            return new Message
            {
                Id = messageDTO.Id,
                SenderId = messageDTO.SenderId,
                ReciverId = messageDTO.RenderId,
                Content = messageDTO.Content,
                CreatedAt = messageDTO.CreatedAt,
                Read = messageDTO.Read
            };
        }
    }
}