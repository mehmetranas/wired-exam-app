namespace WiredExamApp.Core.DTOs
{
    public class AnswerResponseDto
    {
        public string QuestionId { get; set; }
        public string RightAnswerValue { get; set; }
        public bool ClientIsRight { get; set; }
    }
}