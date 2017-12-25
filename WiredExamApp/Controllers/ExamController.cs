using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Helper;
using WiredExamApp.Models;
using WiredExamApp.Persistence.Repositories;

namespace WiredExamApp.Controllers
{
    public class ExamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamController()
        {
            var context = new ApplicationDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        // GET: Exam
        public async Task<ActionResult> Create()
        {
            var wiredService = new WiredService();
            var titles = await wiredService.GetRecentArticleTitle("https://www.wired.com/");

            return View(titles);
        }

        public ActionResult Edit()
        {
            var exams = _unitOfWork.Exam.GetExamTitles();

            return View(exams);
        }
    }
}