using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class BookingDetail : INotifyPropertyChanged
    {
        public int _bookingReservationId;
        public int _roomId;
        public DateTime _startDate;
        public DateTime _endDate;
        public decimal _actualPrice;

        public int BookingReservationId
        {
            get => _bookingReservationId;
            set
            {
                if (_bookingReservationId != value)
                {
                    _bookingReservationId = value;
                    OnPropertyChanged(nameof(BookingReservationId));
                }
            }

        }

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
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    OnPropertyChanged(nameof(StartDate));
                }
            }

        }
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    OnPropertyChanged(nameof(EndDate));
                }
            }

        }
        public decimal ActualPrice
        {
            get => _actualPrice;
            set
            {
                if (_actualPrice != value)
                {
                    _actualPrice = value;
                    OnPropertyChanged(nameof(ActualPrice));
                }
            }

        }
        public BookingDetail(int booking_id, int roomId, DateTime startDate, DateTime endDate, decimal price)
        {
            this._bookingReservationId = booking_id;
            this._roomId = roomId;
            this._startDate = startDate;
            this._endDate = endDate;
            this._actualPrice = price;
        }

        public BookingDetail() { }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
