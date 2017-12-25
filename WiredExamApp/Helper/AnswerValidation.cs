using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Core.DTOs;
using WiredExamApp.Core.Models;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Persistence.Model;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Helper
{
    public class AnswerValidation
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerValidation()
        {
            var context = new ApplicationDbContext();
            _unitOfWork = new UnitOfWork(context);
        }
        public IEnumerable<AnswerResponseDto> CheckClientAnswers(AnswerRequestDto[] answersRequestDto)
        {
            var answerResponseDtos = new List<AnswerResponseDto>();

            foreach (var answer in answersRequestDto)
            {
                var answerResponseDto = new AnswerResponseDto();

                var questionAnswer = _unitOfWork.Question
                    .GetQuestionAnswerById(int.Parse(answer.QuestionId));
                answerResponseDto.ClientIsRight = answer.AnswerValue == questionAnswer;
                answerResponseDto.QuestionId = answer.QuestionId;
                answerResponseDto.RightAnswerValue = questionAnswer;
                answerResponseDtos.Add(answerResponseDto);
            }

            return answerResponseDtos;

        }
    }
}