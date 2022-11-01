using System.ComponentModel.DataAnnotations;

namespace SongTheBlog.Dto.User
{
    public class PutUserDto
    {
        public String DisplayName { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        public String Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
    }
}