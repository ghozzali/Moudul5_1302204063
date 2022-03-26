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
public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(String a)
        {
            Debug.Assert(a != null && a.Length < 101);
            Random c = new Random();
            this.id = c.Next(10000, 100000);//in range 10000-100000
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = a;

        }

        public int GetTotalVideoPlayCount()
        {
            int hasil = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                hasil += video.getPlay();
            }
            return hasil;
        }

        public void AddVideos(SayaTubeVideo a)
        {
            Debug.Assert(a != null);

            Debug.Assert(a.getPlay() <= 2147483647);
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlayCount()
        {

            Console.WriteLine("User :" + this.username);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul : " + this.uploadedVideos[i].getTitle());
                i++;
            }
        }
}
public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        //public int a;

        public SayaTubeVideo(string a)
        {
            Debug.Assert(a != null && a.Length < 201);
            Random b = new Random();

            this.id = b.Next(10000, 100000);//in range 10000-100000
            this.title = a;
            playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            Debug.Assert(a <= 25000000 && a > -1);
            try
            {
                playCount = checked(playCount + a);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
            }
        }

        public int getPlay()
        {
            return playCount;
        }
        public string getTitle()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
    }
}
