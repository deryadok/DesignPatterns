using DecoratorPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("J.R.R Tolkien", "Yüklerin Efendisi: Yüzük Kardeşliği", 1000);
            book.Display();

            Video video = new Video("Peter Jackson", "Yüklerin Efendisi: Yüzük Kardeşliği", 228, 100);
            video.Display();


            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");


            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            borrowvideo.ReturnItem("Customer #1");
            borrowvideo.Display();

            Console.ReadKey();
        }
    }
}
