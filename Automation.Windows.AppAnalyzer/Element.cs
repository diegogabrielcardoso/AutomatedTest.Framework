using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;

namespace WindowsAppAnalyzer
{
    public class Element
    {

        public Element()
        {
            Elements = new List<Element>();
        }

        public IUIItem Target { get; set; }

        public string Text { get; set; }

        public List<Element> Elements { get; set; }

    }
}
