using BlueMusicAPI.Data;
using BlueMusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BlueMusicAPI.Services
{
    public class MusicService : IMusicService
    {
        BlueMusicContext _context;

        public MusicService(BlueMusicContext context)
        {
            _context = context;
        }

        public List<Music> All()
        {
            return _context.Music.ToList();
        }

        public Music Get(int? id)
        {
            return _context.Music.FirstOrDefault(m => m.Id == id);
        }

        public bool Create(Music m)
        {
            try
            {
                _context.Add(m);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Music m)
        {
            try
            {
                if (!_context.Music.Any(music => music.Id == m.Id))
                    throw new Exception("A música solicitado não consta em nossa base de dados!");

                _context.Update(m);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
