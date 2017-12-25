using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Core.DTOs;

namespace WiredExamApp.Helper
{
    public static class Validations
    {
        public static bool ExamDtoCreatealidation(ExamDto examDto)
        {
            foreach (var dtoQuestion in examDto.Questions)
            {
                if (string.IsNullOrWhiteSpace(dtoQuestion.Answer) || string.IsNullOrWhiteSpace(dtoQuestion.QuestionText))
                    return false;
                if (dtoQuestion.Selections.Any(selection => string.IsNullOrWhiteSpace(selection.Text)))
                    return false;
            }
            return true;
        }
    }
}