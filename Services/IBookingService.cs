using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookingService
    {
        //Booking Detail
        //void SaveBookingDetail(BookingDetail d);
        void DeleteBookingDetail(BookingDetail d);
        void UpdateBookingDetail(BookingDetail d);
        ObservableCollection<BookingDetail> GetDetails();
        BookingDetail GetDetailById(int id);
        //Booking Reservation
        void SaveBookingReservation(BookingReservation r);
        void DeleteBookingReservation(BookingReservation r);
        void UpdateBookingReservation(BookingReservation r);
        ObservableCollection<BookingReservation> GetReservations();
        BookingReservation GetReservationById(int id);
    }
}
