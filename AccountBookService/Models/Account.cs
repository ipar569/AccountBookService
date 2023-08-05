namespace AccountBookService.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}