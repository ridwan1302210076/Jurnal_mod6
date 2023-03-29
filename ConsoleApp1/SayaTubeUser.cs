using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeUser> uploadedvideos;
        private String Username;
      

        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            uploadedvideos = new List<SayaTubeUser>();
            this.id = new Random().Next(10000, 99999);
        }

        public void GetTotalvideoPlaycount()
        {
            return uploadedvideos.Sum(x => x.playcount);
        }
        
        public void AddVideo()
        {

        }

        public void PrintAllVideoPlaycount()
        {

        }
    }
}
