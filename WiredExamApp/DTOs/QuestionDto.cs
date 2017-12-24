using System.Collections.Generic;

namespace WiredExamApp.DTOs
{
    public class QuestionDto
    {
        public string QuestionText { get; set; }
        public ICollection<SelectionDto> Selections { get; set; }
        public string Answer { get; set; }
    }
}