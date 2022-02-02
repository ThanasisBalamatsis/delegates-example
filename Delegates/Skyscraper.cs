using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Skyscraper
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        public void Modify(Action<Skyscraper> actionHandler)
        {
            actionHandler(this);
        }
    }
}
