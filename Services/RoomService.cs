using BussinessObjects;
using Reponsitory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoomService :IRoomService
    {
        private readonly IRoomRepository iRoomRepository;
        public RoomService()
        {
            iRoomRepository = new RoomRepository();
        }

        public void DeleteRoom(RoomInformation r)
        {
            iRoomRepository.DeleteRoom(r);
        }
        public void DeleteRoomType(RoomType t)
        {
            iRoomRepository.DeleteRoomType(t);
        }
        public void SaveProduct(RoomInformation r)
        {
            iRoomRepository.SaveRoom(r);
        }
        public void SaveRoom(RoomInformation r)
        {
            iRoomRepository.SaveRoom(r);
        }
        public void SaveRoomType(RoomType t)
        {
            iRoomRepository.SaveRoomType(t);
        }
        public void UpdateRoom(RoomInformation r)
        {
            iRoomRepository.UpdateRoom(r);
        }
        public void UpdateRoomType(RoomType t)
        {
            iRoomRepository.UpdateRoomType(t);
        }
        public RoomInformation GetRoomById(int id)
        {
            return iRoomRepository.GetRoomById(id);
        }
        public RoomType GetTypeById(int id)
        {
            return iRoomRepository.GetTypeById(id);
        }
        public ObservableCollection<RoomInformation> GetRooms()
        {
            return iRoomRepository.GetRooms();
        }
        public ObservableCollection<RoomType> GetRoomTypes()
        {
            return iRoomRepository.GetRoomTypes();
        }
    }
}
