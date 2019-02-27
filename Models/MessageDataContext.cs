using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard22.Models
{
    public class MessageDataContext :DbContext
    {
        public MessageDataContext(DbContextOptions<MessageDataContext> options)
            : base(options)
        {

        }
        public DbSet<MessageData> messageData { get; set; }
    }
}
