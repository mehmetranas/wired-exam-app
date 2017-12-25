using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HtmlAgilityPack;
using WiredExamApp.Helper;

namespace WiredExamApp.Controllers.API_Controllers
{
    [Authorize]
    public class WiredServiceController : ApiController
    {
        [HttpGet]
        public async Task<string> GetArticle(string queryString)
        {
            var wiredService = new WiredService();
            var url = "https://www.wired.com" + queryString;
            var article = await wiredService.ParsingAritcle(url);
            return article;
        }
    }
}
