using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WiredExamApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string QuestionText { get; set; }
        public ICollection<Selection> Selections { get; set; }
        [Required]
        public string Answer { get; set; }
        public Exam Exam { get; set; }
        public int ExamId { get; set; }
    }
}