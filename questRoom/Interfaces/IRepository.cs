using questRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questRoom.Interfaces
{
   public interface IRepository
    {
        List<Room> GetAllRooms();

        Room GetRoom(int idRoom);

        void AddRoom(Room room);

        void DeleteRoom(int idRoom);

        void DeleteLogo(int idRoom);

        void DeleteGalleryPic(int idRoom, int indexPic);

        void EditRoom(Room newRoom);

        void DeletePhone(int idRoom, int indexPhone);
    }
}
