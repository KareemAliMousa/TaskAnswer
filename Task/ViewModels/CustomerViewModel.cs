namespace TaskAnswer.ViewModels
{
    public class CustomerViewModel
    {
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
    }
}
