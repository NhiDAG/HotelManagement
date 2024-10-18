using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reponsitory
{
    public interface IRoomRepository
    {
        //room information
        void SaveRoom(RoomInformation r);
        void DeleteRoom(RoomInformation r);
        void UpdateRoom(RoomInformation r);
        ObservableCollection<RoomInformation> GetRooms();
        RoomInformation GetRoomById(int id);
        //roomtype
        void SaveRoomType(RoomType t);
        void DeleteRoomType(RoomType t);
        void UpdateRoomType(RoomType t);

        ObservableCollection<RoomType> GetRoomTypes();
        RoomType GetTypeById(int id);
    }
}
