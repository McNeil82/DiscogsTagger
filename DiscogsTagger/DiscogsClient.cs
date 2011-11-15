using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DiscogsTagger
{
    class DiscogsClient
    {
        private string url = "http://api.discogs.com/release/";

        public string getReleaseContent(string releaseNumber) {
            string fullUrl = url + releaseNumber;

            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(fullUrl);
            webRequest.Accept = "application/xml";
            webRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip");
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader response = new StreamReader(webResponse.GetResponseStream());
            return response.ReadToEnd();
        }
    }
}
