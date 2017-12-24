using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using WiredExamApp.Models;

namespace WiredExamApp.Helper
{
    public class WiredService
    {
        public async Task<List<Title>> GetRecentArticleTitle(string url)
        {
            //ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var http = new HttpClient();
            var response = await http.GetByteArrayAsync(url);
            var source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = WebUtility.HtmlDecode(source);
            var resultat = new HtmlDocument();
            resultat.LoadHtml(source);

            var RecentArticlesDiv = resultat.DocumentNode.Descendants().Where
            (x => x.Name == "div" && x.Attributes["class"] != null
                                  && x.Attributes["class"].Value.Contains("secondary-grid-component")).ToList();

            var wrapperCards = RecentArticlesDiv[0].Descendants("div").Where
            (x => (x.Name == "div" && x.Attributes["class"] != null)
                  && x.Attributes["class"].Value.Contains("wrapper-cards")).ToList();

            var ul = wrapperCards[0].Descendants().Where
            (x => x.Name == "ul" && x.Attributes["class"] != null &&
                  x.Attributes["class"].Value.Contains("post-listing-component__list")).ToList();

            var li = ul[0].Descendants().Where
                (x => x.Name == "li" && x.Attributes["class"] != null).ToList();

            return (
                    from item in li
                    let link =  item.Descendants("a").ToList()[0].GetAttributeValue("href", null)
                    let title = item.Descendants("h5").ToList()[0].InnerText
                    select new Title(){ArticleTitle = title,ArticleLink = link})
                .ToList();
        }

        public async Task<string> ParsingAritcle(string url)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var http = new HttpClient();
            var response = await http.GetByteArrayAsync(url);
            var source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = WebUtility.HtmlDecode(source);
            var resultat = new HtmlDocument();
            resultat.LoadHtml(source);

            var toftitle = resultat.DocumentNode.Descendants().Where
                (x => (x.Name == "article" && x.Attributes["class"] != null)).ToList();

            var article = "";

            var div = toftitle[0].Descendants("div").ToList();

            var li = div[0].Descendants("p").ToList();

            foreach (var item in li)
            {
                article += item.InnerText;
            }

            return article;
        }
    }
}