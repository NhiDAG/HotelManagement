using BussinessObjects;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reponsitory
{
    public class RoomRepository : IRoomRepository
    {
        private RoomDAO roomDAO;

        public RoomRepository()
        {
            roomDAO = getRoomInstance();
            roomDAO = getTypeInstance();
        }

        private RoomDAO getRoomInstance()
        {
            if (roomDAO == null)
            {
                roomDAO = new RoomDAO();
            }
            return roomDAO;
        }

        private RoomDAO getTypeInstance()
        {
            if (roomDAO == null)
            {
                roomDAO = new RoomDAO();
            }
            return roomDAO;
        }
        public void DeleteRoom(RoomInformation r) => roomDAO.DeleteRoom(r);
        public void SaveRoom(RoomInformation r) => roomDAO.SaveRoom(r);
        public void UpdateRoom(RoomInformation r) => roomDAO.UpdateRoom(r);
        public ObservableCollection<RoomInformation> GetRooms() => roomDAO.GetRooms();
        public RoomInformation GetRoomById(int id) => roomDAO.GetRoomById(id);

        public void DeleteRoomType(RoomType t) => roomDAO.DeleteRoomType(t);
        public void SaveRoomType(RoomType t) => roomDAO.SaveRoomType(t);
        public void UpdateRoomType(RoomType t) => roomDAO.UpdateRoomType(t);

        public ObservableCollection<RoomType> GetRoomTypes() => roomDAO.GetRoomTypes();
        public RoomType GetTypeById(int id) => roomDAO.GetTypeById(id);

       
    }
}
