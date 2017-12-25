using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WiredExamApp.Core.DTOs;
using WiredExamApp.Core.Models;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Helper;
using WiredExamApp.Persistence.Model;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers.API_Controllers
{
    public class AnswerController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IEnumerable<AnswerResponseDto> CheckAnswers(AnswerRequestDto[] answersRequestDto)
        {
            var answerValidation = new AnswerValidation(_unitOfWork);
            return answerValidation.CheckClientAnswers(answersRequestDto);
        }
    }
}
