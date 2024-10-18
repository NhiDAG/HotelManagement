using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessObject
{
    public class BookingDAO
    {
        private static ObservableCollection<BookingDetail> listBookingDetails;
        private static ObservableCollection<BookingReservation> listBookingReservations;

        private ObservableCollection<BookingDetail> getDetailInstance()
        {
            if (listBookingDetails == null)
            {
                BookingDetail bd1 = new BookingDetail(1, 3, Convert.ToDateTime("01/01/2024"), Convert.ToDateTime("02/01/2024"), 1990000);
                BookingDetail bd2 = new BookingDetail(2, 5, Convert.ToDateTime("05/01/2024"), Convert.ToDateTime("08/01/2024"), 1790000);
                listBookingDetails = new ObservableCollection<BookingDetail> { bd1, bd2 };
            }
            return listBookingDetails;
        }

        private ObservableCollection<BookingReservation> getReservationInstance()
        {
            if (listBookingReservations == null)
            {
                BookingReservation br1 = new BookingReservation(1, Convert.ToDateTime("20/12/2023"), 3780000, 3, "Pending");
                BookingReservation br2 = new BookingReservation(2, Convert.ToDateTime("21/12/2023"), 14930000, 3, "Paid");
                listBookingReservations = new ObservableCollection<BookingReservation> {br1, br2};
            }
            return listBookingReservations;
        }

        public BookingDAO()
        {
            listBookingDetails = getDetailInstance();
            listBookingReservations = getReservationInstance();
        }

        public ObservableCollection<BookingDetail> GetDetails()
        {
            return listBookingDetails;
        }

        public ObservableCollection<BookingReservation> GetReservations()
        {
            return listBookingReservations;
        }

        //public void CreateBookingReservation(BookingReservation r)
        //{

        //}

        //public void SaveBookingDetail(BookingDetail d)
        //{
        //    d.BookingReservationId = listBookingReservations.BookingReservationId;
        //    listBookingDetails.Add(d);
        //}

        public void SaveBookingReservation(BookingReservation r)
        {
            r.BookingReservationId = listBookingReservations.Count + 1;
            listBookingReservations.Add(r);
        }

        public void UpdateBookingReservation(BookingReservation reservation)
        {
            foreach (BookingReservation r in listBookingReservations.ToList())
            {
                if (r.BookingReservationId == reservation.BookingReservationId)
                {
                    r.BookingReservationId = reservation.BookingReservationId;
                    r.BookingDate = reservation.BookingDate;
                    r.TotalPrice = reservation.TotalPrice;
                    r.CustomerId = reservation.CustomerId;
                    r.BookingStatus = reservation.BookingStatus;

                }
            }
        }

        public void UpdateBookingDetail(BookingDetail detail)
        {
            foreach (BookingDetail d in listBookingDetails.ToList())
            {
                if (d.BookingReservationId == detail.BookingReservationId)
                {
                    d.BookingReservationId = detail.BookingReservationId;
                    d.RoomId = detail.RoomId;
                    d.StartDate = detail.StartDate;
                    d.EndDate = detail.EndDate;
                    d.ActualPrice = detail.ActualPrice;
                }
            }
        }

        public void DeleteBookingReservation(BookingReservation reservation)
        {
            foreach (BookingReservation r in listBookingReservations.ToList())
            {
                if (r.BookingReservationId == reservation.BookingReservationId)
                {
                    listBookingReservations.Remove(r);
                    break;
                }
            }
        }

        public void DeleteBookingDetail(BookingDetail detail)
        {
            foreach (BookingDetail d in listBookingDetails.ToList())
            {
                if (d.BookingReservationId == d.BookingReservationId)
                {
                    listBookingDetails.Remove(d);
                    break;
                }
            }
        }

        public BookingDetail GetDetailById(int id)
        {
            foreach (BookingDetail d in listBookingDetails.ToList())
            {
                if (d.BookingReservationId == id)
                {
                    return d;
                }
            }
            return null;
        }
        public BookingReservation GetReservationById(int id)
        {
            foreach (BookingReservation r in listBookingReservations.ToList())
            {
                if (r.BookingReservationId == id)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
