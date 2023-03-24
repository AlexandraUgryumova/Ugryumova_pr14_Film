using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_14_Фильмотека
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmoteka fm = new Filmoteka();
            fm.Film("Секс в большом городе", "HBO", new TimeSpan(1, 20, 10), "комедия");
        }
    }
}
