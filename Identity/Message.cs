using System;
using System.ComponentModel.DataAnnotations;

namespace chat_application.Identity
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        
        [MaxLength(50)]
        public string SenderName { get; set; }

        [MaxLength(50)]
        public string ReceiverName { get; set; }

        [MaxLength(144)]
        public string MessageContent { get; set; }
        
        public bool isRead { get; set; }
        
        public DateTime MessageDate { get; set; }
    }
}