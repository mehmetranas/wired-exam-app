using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var exams = _unitOfWork.Exam.GetExams();
;           return View(exams);
        }
    }
}