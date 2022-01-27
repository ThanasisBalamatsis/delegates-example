using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Skyscraper
    {
        public int Height { get; set; }
        public Color Color { get; set; }

        public void Modify(Skyscraper skyscraper, Action<Skyscraper> actionHandler)
        {
            actionHandler(skyscraper);
        }
    }
}
