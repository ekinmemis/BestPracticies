using Basic.Core.Entities;

namespace Basic.Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
