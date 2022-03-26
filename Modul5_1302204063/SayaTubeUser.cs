using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul5_1302204063
{
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
}

