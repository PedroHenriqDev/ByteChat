namespace ByteChat.Domain.Entities
{
    public class Message : Entity
    {
        public string Content { get; set; } = string.Empty;
        public EMessageType Type { get; set; }
    }
}
