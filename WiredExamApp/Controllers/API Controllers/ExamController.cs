using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using AutoMapper;
using WiredExamApp.Core.DTOs;
using WiredExamApp.Core.Models;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Helper;
using WiredExamApp.Persistence.Model;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers.API_Controllers
{
    [Authorize]
    public class ExamController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult CreateExam(ExamDto examDto)
        {
            var modelValidate = Validations.ExamDtoCreatealidation(examDto);

            if (!modelValidate) return BadRequest();

            var exam = Mapper.Map<ExamDto,Exam>(examDto);
            exam.CreateDateTime = DateTime.Now;
            _unitOfWork.Exam.Add(exam);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteExam(int id)
        {
            var isRemove = _unitOfWork.Exam.Remove(id);
            _unitOfWork.Complete();
            if (isRemove) return Ok();
            return BadRequest();
        }

    }
}
