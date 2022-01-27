using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Skyscraper skyscraper = new Skyscraper()
            {
                Height = 100,
                Color = Color.Red
            };

            Action<Skyscraper> actionHandler = SkyscraperService.ChangeColor;
            actionHandler += SkyscraperService.ChangeHeight;

            skyscraper.Modify(actionHandler);
        }
    }
}
