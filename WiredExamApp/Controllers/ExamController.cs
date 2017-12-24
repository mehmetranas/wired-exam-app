using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WiredExamApp.Helper;
using WiredExamApp.Models;

namespace WiredExamApp.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public async Task<ActionResult> RecentArticles()
        {
            var wiredService = new WiredService();
            var titles = await wiredService.GetRecentArticleTitle("https://www.wired.com/");

            return View(titles);
        }
    }
}