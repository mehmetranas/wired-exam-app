using System.ComponentModel.DataAnnotations;

namespace WiredExamApp.Core.Models
{
    public class Selection
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}