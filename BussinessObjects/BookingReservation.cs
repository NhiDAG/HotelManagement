using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class BookingReservation : INotifyPropertyChanged
    {
        public int _bookingReservationId;
        public DateTime _bookingDate;
        public decimal _totalPrice;
        public int _customerId;
        public string _bookingStatus;

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

        public DateTime BookingDate
        {
            get => _bookingDate;
            set
            {
                if (_bookingDate != value)
                {
                    _bookingDate = value;
                    OnPropertyChanged(nameof(BookingDate));
                }
            }

        }
        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                if (_totalPrice != value)
                {
                    _totalPrice = value;
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }

        }
        public int CustomerId
        {
            get =>_customerId;
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    OnPropertyChanged(nameof(CustomerId));
                }
            }

        }
        public string BookingStatus
        {
            get => _bookingStatus;
            set
            {
                if (_bookingStatus != value)
                {
                    _bookingStatus = value;
                    OnPropertyChanged(nameof(BookingStatus));
                }
            }

        }
        public BookingReservation(int booking_id, DateTime bookingDate, decimal totalPrice, int customerId, string status)
        {
            this._bookingReservationId = booking_id;
            this._bookingDate = bookingDate;
            this._totalPrice = totalPrice;
            this._customerId = customerId;
            this._bookingStatus = status;
        }

        public BookingReservation() { }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
