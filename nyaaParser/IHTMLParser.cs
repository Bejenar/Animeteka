using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyaaParser
{
    public interface IHTMLParser
    {
        string BaseUrl { get; }
        string SearchString { get; set; }
        string AbsoluteUrl { get; }
        
        List<ParserEntry> GetParserEntries(string searchString);
    }
}
