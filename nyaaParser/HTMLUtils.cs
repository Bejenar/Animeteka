using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nyaaParser
{
    public class HTMLUtils
    {
        public static string getHtml(string website)
        {
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                client.Encoding = Encoding.UTF8;
                // Or you can get the file content without saving it
                return client.DownloadString(website);

            }
        }
    }
}
