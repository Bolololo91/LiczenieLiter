using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczeni_Liter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char letter = Console.ReadKey().KeyChar;
            char[] textchar = text.ToArray();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (textchar[i] == letter)
                {
                    counter++;
                }
               
            }
            Console.Clear();
            Console.WriteLine("Szukanych liter Jest " + counter);
            Console.ReadLine();


        }
    }
}
