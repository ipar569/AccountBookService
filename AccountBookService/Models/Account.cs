using System.ComponentModel.DataAnnotations;

namespace AccountBookService.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        public User AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}