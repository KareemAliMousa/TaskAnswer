namespace TaskAnswer.Models
{
    public class Customer : BaseEntity
    {
        [MaxLength(100)]
        public string Code { get; set; } = string.Empty;
        public DateTime DateOfRegistration { get; set; } = DateTime.Now; 
        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
        public string? Token { get; set; }
    }
}
