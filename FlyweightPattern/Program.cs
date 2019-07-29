using FlyweightPattern.Abstract;
using FlyweightPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string document = "AABBABABAAABBA";

            char[] chars = document.ToArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.ReadKey();
        }
    }
}
