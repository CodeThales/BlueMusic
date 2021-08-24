using BlueMusicAPI.Models;
using System.Collections.Generic;

namespace BlueMusicAPI.Services
{
    public interface IMusicService
    {
        List<Music> All();
        Music Get(int? id);
        bool Create(Music m);
        bool Update(Music m);
        bool Delete(int? id);
    }
}