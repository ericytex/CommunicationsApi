using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CommunicationsApi.Models;

namespace CommunicationsApi.Models.Data
{
    public class MessageContext:DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {

        }
        public DbSet<CommunicationsApi.Models.MessageModel>? MessageModel { get; set; }


    }   
}
