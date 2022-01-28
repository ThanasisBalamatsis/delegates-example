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

            Action<Skyscraper> changeName = s => Console.WriteLine("The skyscraper's name is"); // I'm learning about lambda expressions and their conversion to delegates, that's why I added this

            Action<Skyscraper> actionHandler = SkyscraperService.ChangeColor;
            actionHandler += SkyscraperService.ChangeHeight;
            actionHandler += changeName;

            skyscraper.Modify(actionHandler);
        }
    }
}
