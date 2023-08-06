using System.ComponentModel.DataAnnotations;

namespace AccountBookService.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
         public DateTime CreatedTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}