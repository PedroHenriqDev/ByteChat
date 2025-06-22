using System.Collections;

namespace ByteChat.Domain.Entities
{
    public class Chat : Entity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
