using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WiredExamApp.DTOs;

namespace WiredExamApp.Controllers.API_Controllers
{
    public class AnswerController : ApiController
    {

        [HttpPost]
        public IHttpActionResult CheckAnswers(AnswerDto[] answersDto)
        {
            if(answersDto.Count()>0)
            return Ok();
            else
            {
                return Json(answersDto);
            }
        }
    }
}
