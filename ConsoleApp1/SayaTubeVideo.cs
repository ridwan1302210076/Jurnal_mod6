using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        public int playCount;


        public SayaTubeVideo(String title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int input)
        {
            this.playCount += input;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}\nTitle: {this.title}\nPlay Count: {this.playCount}\n");
        }

        public string GetTitle()
        {
            return title;
        }
        
    }
}
