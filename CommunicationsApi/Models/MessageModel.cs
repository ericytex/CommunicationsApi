using System.ComponentModel.DataAnnotations;

namespace CommunicationsApi.Models
{
    public class MessageModel
    {
        [Key]
        public int Id { get; set; }
        public string? Message { get; set; }
        public DateTime MessageDate { get; set; }
        public string? MessageTime { get; set; }
        public string? FromWho { get; set; }
        public string? ToWho { get; set; }
        public string? MessageSubject { get; set; }

        public string? MessageBody { get; set; }
        public bool MessageDeliveredStatus { get; set; }
        public bool MessageSentStatus { get; set; }
        public bool MessageRecievedStatus { get; set; }
        public bool MessageReadStatus { get; set; }
        public bool MessageSavedStatus { get; set; }
        public bool MessageDeletedStatus { get; set; }
        public DateTime MessageStatusDate { get; set; }

    }

    public enum MessageStatus
    {
        Delivered,
        Sent,
        Recieved,
        Read,
        Saved,
        Deleted
    }
}
