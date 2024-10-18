using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public partial class RoomType : INotifyPropertyChanged
    {
        public int _roomTypeId;
        public string _roomTypeName;
        public string _typeDescription;
        public string _typeNote;
        
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

        public string RoomTypeName
        {
            get => _roomTypeName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                {
                    throw new ArgumentException("Room type name cannot be empty and must not exceed 50 characters.");
                }
                if (_roomTypeName != value)
                {
                    _roomTypeName = value;
                    OnPropertyChanged(nameof(RoomTypeName));
                }
            }
        }

        public string TypeDescription
        {
            get => _typeDescription;
            set
            {
                if (value.Length > 250)
                {
                    throw new ArgumentException("Type description must not exceed 250 characters.");
                }
                if (_typeDescription != value)
                {
                    _typeDescription = value;
                    OnPropertyChanged(nameof(TypeDescription));
                }
            }
        }

        public string TypeNote
        {
            get => _typeNote;
            set
            {
                if (value.Length > 250)
                {
                    throw new ArgumentException("Type note must not exceed 250 characters.");
                }
                if (_typeNote != value)
                {
                    _typeNote = value;
                    OnPropertyChanged(nameof(TypeNote));
                }
            }
        }

        public RoomType(int roomTypeId, string roomTypeName, string typeDescription, string typeNote)
        {
            RoomTypeId = roomTypeId;
            RoomTypeName = roomTypeName;
            TypeDescription = typeDescription;
            TypeNote = typeNote;
        }

        public RoomType() { }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
