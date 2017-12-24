using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using WiredExamApp.Core.Repositories;
using WiredExamApp.DTOs;
using WiredExamApp.Helper;
using WiredExamApp.Models;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers.API_Controllers
{
    public class ExamController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamController(ApplicationDbContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public IHttpActionResult CreateExam(ExamDto examDto)
        {
            var modelValidate = Validations.ExamDtoCreatealidation(examDto);

            if (!modelValidate) return BadRequest();

            var exam = Mapper.Map<ExamDto,Exam>(examDto); 
            //_unitOfWork.Exam.Add(exam);
            //_unitOfWork.Complete();
            return Ok();
        }

        
    }
}
