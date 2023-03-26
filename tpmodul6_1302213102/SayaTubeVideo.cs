using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213102
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rnd = new Random();

        public SayaTubeVideo(String judul)
        { 
            title = judul;
            id = rnd.Next(00000,99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Film = " + id);
            Console.WriteLine("Judul FIlm = " + title);
            Console.WriteLine("Jumlah diputar = " + playCount);
        }
    }
}
