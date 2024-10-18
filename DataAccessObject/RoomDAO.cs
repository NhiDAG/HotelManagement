using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class RoomDAO
    {
        private static ObservableCollection<RoomInformation> listRooms;
        private static ObservableCollection<RoomType> listRoomTypes;

        private ObservableCollection<RoomInformation> getRoomInstance()
        {
            if (listRooms == null)
            {
                RoomInformation room1 = new RoomInformation(1, "2364", "A basic room with essential amenities, suitable for individual travelers or couples", 3, 1, 1, 1490000);
                RoomInformation room2 = new RoomInformation(2, "3345", "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor", 5, 3, 1, 2990000);
                RoomInformation room3 = new RoomInformation(3, "4432", "A luxurious and spacious room with separate living and sleeping areas, ideal for guests seeking extra comfort and space", 4, 2, 1, 1990000);
                RoomInformation room4 = new RoomInformation(5, "3342", "Foor 3, Window in the North West", 5, 5, 1, 2190000);
                RoomInformation room5 = new RoomInformation(7, "4434", "Floor 4, main window in the South", 4, 1, 1, 1790000);
                listRooms = new ObservableCollection<RoomInformation> { room1,room2, room3,room4,room5};
            }
            return listRooms;
        }

        private ObservableCollection<RoomType> getTypeInstance()
        {
            if (listRoomTypes == null)
            {
                RoomType type1 = new RoomType(1, "Standard room", "This is typically the most affordable option and provides basic amenities such as a bed, dresser, and TV", "N/A");
                RoomType type2 = new RoomType(2, "Suite", "Suites usually offer more space and amenities than standard rooms, such as a separate living area, kitchenette, and multiple bathrooms", "N/A");
                RoomType type3 = new RoomType(3, "Deluxe room", "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor", "N/A");
                RoomType type4 = new RoomType(4, "Executive room", "Executive rooms are designed for business travelers and offer perks such as free breakfast, evening drink, and high-speed internet", "N/A");
                RoomType type5 = new RoomType(5, "Family Room", "A room specifically designed to accommodate families, often with multiple beds and additional space for children", "N/A");
                RoomType type6 = new RoomType(6, "Connecting Room", "Two or more rooms with a connecting door, providing flexibility for larger groups or families traveling together", "N/A");
                RoomType type7 = new RoomType(7, "Penthouse Suite", "An extravagant, top-floor suite with exceptional views and exclusive amenities, typically chosen for special occasions or VIP guests", "N/A");
                RoomType type8 = new RoomType(8, "Bungalow", "A standalone cottage-style accommodation, providing privacy and a sense of seclusion often within a resort setting", "N/A");
                listRoomTypes = new ObservableCollection<RoomType> { type1, type2, type3, type4, type5, type6, type7, type8};
            }
            return listRoomTypes;
        }

        public RoomDAO()
        {
            listRooms = getRoomInstance();
            listRoomTypes = getTypeInstance();
        }
        public ObservableCollection<RoomInformation> GetRooms()
        {
            return listRooms;
        }
        public ObservableCollection<RoomType> GetRoomTypes()
        {
            return listRoomTypes;
        }

        public void SaveRoom(RoomInformation r)
        {
            r.RoomId = listRooms.Count + 1;
            listRooms.Add(r);
        }

        public void SaveRoomType(RoomType t)
        {
            t.RoomTypeId = listRoomTypes.Count + 1;
            listRoomTypes.Add(t);
        }

        public void UpdateRoom(RoomInformation room)
        {
            foreach (RoomInformation r in listRooms.ToList())
            {
                if (r.RoomId == room.RoomId)
                {
                    r.RoomId = room.RoomId;
                    r.RoomNumber = room.RoomNumber;
                    r.RoomDescription = room.RoomDescription;
                    r.RoomMaxCapacity = room.RoomMaxCapacity;
                    r.RoomStatus = room.RoomStatus;
                    r.RoomPricePerDate = room.RoomPricePerDate;
                    r.RoomTypeId = room.RoomTypeId;
                    
                }
            }
        }

        public void DeleteRoom(RoomInformation room)
        {
            foreach (RoomInformation r in listRooms.ToList())
            {
                if (r.RoomId == room.RoomId)
                {
                    listRooms.Remove(r);
                    break;
                }
            }
        }

        public void UpdateRoomType(RoomType type)
        {
            foreach (RoomType t in listRoomTypes.ToList())
            {
                if (t.RoomTypeId == type.RoomTypeId)
                {
                    t.RoomTypeId = type.RoomTypeId;
                    t.RoomTypeName = type.RoomTypeName;
                    t.TypeNote = type.TypeNote;
                    t.TypeDescription = type.TypeDescription;
                }
            }
        }

        public void DeleteRoomType(RoomType type)
        {
            foreach (RoomType t in listRoomTypes.ToList())
            {
                if (t.RoomTypeId == type.RoomTypeId)
                {
                    listRoomTypes.Remove(t);
                    break;
                }
            }
        }

        public RoomInformation GetRoomById(int room_id)
        {
            foreach (RoomInformation  r in listRooms.ToList())
            {
                if (r.RoomId == room_id)
                {
                    return r;
                }
            }
            return null;
        }

        public RoomType GetTypeById(int type_id)
        {
            foreach (RoomType t in listRoomTypes.ToList())
            {
                if (t.RoomTypeId == type_id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
