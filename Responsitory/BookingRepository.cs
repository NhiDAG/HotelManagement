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
    public class BookingRepository : IBookingRepository
    {
        private BookingDAO bookingDAO;

        public BookingRepository()
        {
            bookingDAO = getDetailInstance();
            bookingDAO = getReservationInstance();
        }

        private BookingDAO getDetailInstance()
        {
            if (bookingDAO == null)
            {
                bookingDAO = new BookingDAO();
            }
            return bookingDAO;
        }

        private BookingDAO getReservationInstance()
        {
            if (bookingDAO == null)
            {
                bookingDAO = new BookingDAO();
            }
            return bookingDAO;
        }
        public void DeleteBookingDetail(BookingDetail d) => bookingDAO.DeleteBookingDetail(d);
        //public void SaveBookingDetail(BookingDetail d) => bookingDAO.SaveBookingDetail(d);
        public void UpdateBookingDetail(BookingDetail d) => bookingDAO.UpdateBookingDetail(d);
        public ObservableCollection<BookingDetail> GetDetails() => bookingDAO.GetDetails();
        public BookingDetail GetDetailById(int id) => bookingDAO.GetDetailById(id);

        public void DeleteBookingReservation(BookingReservation r) => bookingDAO.DeleteBookingReservation(r);
        public void SaveBookingReservation(BookingReservation r) => bookingDAO.SaveBookingReservation(r);
        public void UpdateBookingReservation(BookingReservation r) => bookingDAO.UpdateBookingReservation(r);

        public ObservableCollection<BookingReservation> GetReservations() => bookingDAO.GetReservations();
        public BookingReservation GetReservationById(int id) => bookingDAO.GetReservationById(id);
    }
}
