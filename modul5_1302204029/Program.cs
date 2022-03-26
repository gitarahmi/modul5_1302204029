using System;
using System.Diagnostics;

namespace modul5_1302204029
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public sayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(0, 100000);
            this.playCount = 0;

            Debug.Assert(title.Length != 0, "title tidak boleh kosong");
            Debug.Assert(title.Length < 100, "title kepanjangan");
        }
        public void IncreaseplayCount(int jmlAngka)
        {
            playCount = playCount + jmlAngka;
        }
        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }
    }
    class sayaTubeUser
    {
        private string username;
        private int id;
        private List<sayaTubeVideo> uploadedVideos;

        public sayaTubeUser(string username)
        {
            this.username = username;
        }
    }
}
