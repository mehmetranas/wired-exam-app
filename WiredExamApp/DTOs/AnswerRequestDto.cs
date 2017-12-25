using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiredExamApp.DTOs
{
    public class AnswerRequestDto
    {
        public string QuestionId { get; set; }
        public string AnswerValue { get; set; }
    }
}