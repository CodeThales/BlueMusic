using BlueMusicAPI.Models;
using System;
using System.Collections.Generic;


namespace BlueMusicAPI.Services
{
    public class MusicStaticService : IMusicService
    {
        public List<Music> All()
        {
            //List<Music> listaMusic = new();

            //string[] Names = new string[] { "Transparent Soul”", "Best Friend", "Yonaguni", "Miénteme", "Higher Power", "Astronaut In The Ocean", "Leave Before You Love Me", "Count On Me", "Your Power", "Solar Power" };
            //string[] Authors = new string[] { "Willow e Travis Barker", "Saweetie e Doja Cat", "Bad Bunny", "TINI e Maria Becerra", " Coldplay", "Masked Wolf", "Marshmello e Jonas Brothers", "Brockhampton", "Billie Eilish", "Lorde" };
            //int[] Durations = new int[] { 160, 180, 240, 300, 360, 420, 500, 620, 120, 280 };

            //Random rand = new();
            //var Name = $"{Names[rand.Next(0, Names.Length)]}";
            //var Author = $"{Authors[rand.Next(0, Authors.Length)]}";
            //var Duration = $"{Durations[rand.Next(0, Durations.Length)]}";

            //listaMusic.Add(new Music { Name = "Aways", Author = "Bon Jovi", Duration = 180, Link = "" });

            //return listaMusic;
        }

        public bool Create(Music m)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Music Get(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Music m)
        {
            throw new NotImplementedException();
        }
    }
}
