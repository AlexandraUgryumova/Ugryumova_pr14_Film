using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_14_Фильмотека
{
    internal class Filmoteka
    {
        string name;
        string production;
        TimeSpan time;
        string genre;
        public void Film(string name, string production, TimeSpan time, string genre)
        {
            this.name = name;
            this.production = production;
            this.time = time;
            this.genre = genre;
        }
        class TVshow : Filmoteka
        {
            int count;
        }
        class FeatureFilm : Filmoteka
        {
            DateTime yearOfIssue;
            bool color;
        }
    }
    abstract class KKK
    {

    }
}
