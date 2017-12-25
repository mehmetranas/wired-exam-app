using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Models;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers
{
    public class ExamViewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamViewController()
        {
            var context = new ApplicationDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        // GET: ExamView
        public ActionResult Index(int id)
        {
            var exam = _unitOfWork.Exam.GetExamById(id);
            return View(exam);
        }
    }
}