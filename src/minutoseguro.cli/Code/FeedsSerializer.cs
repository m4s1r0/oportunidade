using minutoseguro.cli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace minutoseguro.cli.Code
{
    public static class FeedsSerializer
    {
        public static IEnumerable<PostViewModel> GetPosts(string rssUrl = "https://www.minutoseguros.com.br/blog/feed/")
        {
            XDocument feedXML = XDocument.Load(rssUrl);

            return from feed in feedXML.Descendants("item")
                   select new PostViewModel()
                   {
                       Title = feed.Element("title").Value,
                       Link = feed.Element("link").Value,
                       Description = feed.Element("description").Value,
                       Creator = feed.Element("{http://purl.org/dc/elements/1.1/}creator").Value,
                       PublishDate = Convert.ToDateTime(feed.Element("pubDate").Value),
                       GUID = feed.Element("guid").Value,
                       Content = feed.Element("{http://purl.org/rss/1.0/modules/content/}encoded").Value,
                       Summary = WordsCounter.GetSummary(feed.Element("{http://purl.org/rss/1.0/modules/content/}encoded").Value)
                   };
        }
    }
}
