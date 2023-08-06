using System.ComponentModel.DataAnnotations;

namespace AccountBookService.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public ExpenseCategory? Category { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }

    public enum ExpenseCategory
    {
        Housing,
        Utilities,
        Transportation,
        GroceriesFood,
        Healthcare,
        Entertainment,
        DebtPayments,
        SavingsInvestments,
        CharitableContributions,
        Gifts,
        Miscellaneous
    }
}

