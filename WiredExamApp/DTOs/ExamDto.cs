using System.Collections.Generic;

namespace WiredExamApp.DTOs
{
    public class ExamDto
    {
        public string ArticleText { get; set; }
        public string Title { get; set; }
        public ICollection<QuestionDto> Questions { get; set; }
    }
}