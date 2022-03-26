using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser a = new SayaTubeUser("Ghozal");
            SayaTubeVideo b = new SayaTubeVideo("Review Film satu oleh Ghozal Imam Perdana");
            SayaTubeVideo c = new SayaTubeVideo("Review Film dua oleh Ghozal Imam Perdana");
            SayaTubeVideo d = new SayaTubeVideo("Review Film tiga oleh Ghozal Imam Perdana");

            a.AddVideos(b);

            a.AddVideos(c);

            a.AddVideos(d);
            a.PrintAllVideoPlayCount();

            Console.WriteLine();
            Console.WriteLine();

            SayaTubeVideo e = new SayaTubeVideo(null);


            for (int i = 0; i < 65538000; i++)
            {
                e.IncreasePlayCount(i);
            }

        }
    }

}
