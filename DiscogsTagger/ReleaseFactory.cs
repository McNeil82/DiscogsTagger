using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DiscogsTagger
{
    class ReleaseFactory
    {
        public static Release createRelease(XElement releaseElement)
        {
            Release release = new Release();
            release.Title = releaseElement.Element("title").Value;
            release.Year = getReleaseYear(releaseElement);
            
            return release;
        }

        private static string getReleaseYear(XElement releaseElement)
        {
            string releaseDate = releaseElement.Element("released").Value;
            if (releaseDate.Length >= 4)
            {
                return releaseDate.Split('-')[0];
            }
            else
            {
                return "";
            }
            
        }
    }
}
