using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public partial class RoomInformation : INotifyPropertyChanged
    {
        public int _roomId;
        public string _roomNumber;
        public string _roomDescription;
        public int _roomMaxCapacity;
        public int _roomStatus;
        public decimal _roomPricePerDate;
        public int _roomTypeId;

        public int RoomId
        {
            get => _roomId;
            set
            {
                if (_roomId != value)
                {
                    _roomId = value;
                    OnPropertyChanged(nameof(RoomId));
                }
            }
        }

        public string RoomNumber
        {
            get => _roomNumber;
            set
            {
                if (_roomNumber != value)
                {
                    _roomNumber = value;
                    OnPropertyChanged(nameof(RoomNumber));
                }
            }
        }

        public string RoomDescription
        {
            get => _roomDescription;
            set
            {
                if (_roomDescription != value)
                {
                    _roomDescription = value;
                    OnPropertyChanged(nameof(RoomDescription));
                }
            }
        }

        [Range(1, 10, ErrorMessage = "Maximum capacity must be between 1 and 10.")]
        public int RoomMaxCapacity
        {
            get => _roomMaxCapacity;
            set
            {
                if (_roomMaxCapacity != value)
                {
                    _roomMaxCapacity = value;
                    OnPropertyChanged(nameof(RoomMaxCapacity));
                }
            }
        }

        public int RoomStatus
        {
            get => _roomStatus;
            set
            {
                if (_roomStatus != value)
                {
                    _roomStatus = value;
                    OnPropertyChanged(nameof(RoomStatus));
                }
            }
        }

        [Range(0.01, 10000.00, ErrorMessage = "Room price must be between 0.01 and 10,000.")]
        public decimal RoomPricePerDate
        {
            get => _roomPricePerDate;
            set
            {
                if (_roomPricePerDate != value)
                {
                    _roomPricePerDate = value;
                    OnPropertyChanged(nameof(RoomPricePerDate));
                }
            }
        }

        public int RoomTypeId
        {
            get => _roomTypeId;
            set
            {
                if (_roomTypeId != value)
                {
                    _roomTypeId = value;
                    OnPropertyChanged(nameof(RoomTypeId));
                }
            }
        }

        public RoomInformation(int roomId, string roomNumber, string roomDescription, int roomMaxCapacity, int roomStatus, decimal roomPricePerDate, int roomTypeId)
        {
            RoomId = roomId;
            RoomNumber = roomNumber;
            RoomDescription = roomDescription;
            RoomMaxCapacity = roomMaxCapacity;
            RoomStatus = roomStatus;
            RoomPricePerDate = roomPricePerDate;
            RoomTypeId = roomTypeId;
        }

        public RoomInformation() { }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
