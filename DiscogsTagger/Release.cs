using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DiscogsTagger
{
    class Release
    {
        public string Title
        {
            private set;
            get;
        }

        public Release(XElement release)
        {
            Title = release.Element("title").Value;
        }
    }
}
