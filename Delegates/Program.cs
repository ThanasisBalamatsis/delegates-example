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
                Name = "Biggie Small",
                Height = 100,
                Color = Color.Red
            };

            Action<Skyscraper> changeName = s => Console.WriteLine($"The skyscraper's name is {s.Name}"); // lambda expression converted to delegates

            Action<Skyscraper> actionHandler = SkyscraperService.ChangeColor;
            actionHandler += SkyscraperService.ChangeHeight;
            actionHandler += changeName;

            skyscraper.Modify(actionHandler);
        }
    }
}
