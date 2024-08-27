using System.ComponentModel.DataAnnotations;

namespace TaskAnswer.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        [MaxLength(200)]
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
