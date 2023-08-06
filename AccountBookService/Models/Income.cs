using System.ComponentModel.DataAnnotations;

namespace AccountBookService.Models
{
    public class Income
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public IncomeCategory? Category { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }

    public enum IncomeCategory
    {
        Salary,
        Rent,
        Bonuses,
        Investments,
        Other
    }
}

