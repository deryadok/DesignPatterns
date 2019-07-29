using DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    class Video : LibraryItem
    {

        private string director;
        private string title;
        private int playTime;

        public Video(string director, string title, int playTime, int numCopies)
        {
            this.director = director;
            this.title = title;
            this.playTime = playTime;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", playTime);
        }
    }
}
