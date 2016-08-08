using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string Name { get; set; }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
