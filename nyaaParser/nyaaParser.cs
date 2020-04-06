using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;
using nyaaParser;

namespace nyaaParser
{
    public class NyaaParser : IHTMLParser
    {
        private string absoluteUrl;

        public string BaseUrl { get; } = "https://nyaa.si/";
        public string SearchString { get; set; }
        public string AbsoluteUrl {
            get
            {
                var uriBuilder = new UriBuilder(BaseUrl);
                var parameters = HttpUtility.ParseQueryString(string.Empty);
                parameters["q"] = SearchString;
                uriBuilder.Query = parameters.ToString();

                absoluteUrl = uriBuilder.Uri.AbsoluteUri;

                return absoluteUrl;
            }
                }

        public List<ParserEntry> GetParserEntries(string searchString)
        {
            SearchString = searchString;
            Console.WriteLine(AbsoluteUrl);

            List<ParserEntry> entries = new List<ParserEntry>();

            string s = HTMLUtils.getHtml(AbsoluteUrl);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(s);

            var result = doc.DocumentNode.SelectNodes("//table//tbody//tr[@class='success']//td[@colspan='2']");

            if(result != null)
            foreach (var r in result)
            {
                string baseUrl = "https://nyaa.si";
                int i = 3;
                if (r.ChildNodes.Count == 3)
                {
                    i = 1;
                }
                string path = r.ChildNodes[i].Attributes["href"].Value;                
                path = path.Replace("view", "download") + ".torrent";
                string fileName = r.ChildNodes[i].InnerText;

                entries.Add(new ParserEntry(baseUrl + path, fileName));
            }

            return entries;
        }

        public override string ToString()
        {
            return "Nyaa.si";
        }
    }
}
