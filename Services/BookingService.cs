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
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository iBookingRepository;
        public BookingService()
        {
            iBookingRepository = new BookingRepository();
        }

        public void DeleteBookingReservation(BookingReservation r)
        {
            iBookingRepository.DeleteBookingReservation(r);
        }
        public void DeleteBookingDetail(BookingDetail d)
        {
            iBookingRepository.DeleteBookingDetail(d);
        }
        public void SaveBookingReservation(BookingReservation r)
        {
            iBookingRepository.SaveBookingReservation(r);
        }
        //public void SaveBookingDetail(BookingDetail d)
        //{
        //    iBookingRepository.SaveBookingDetail(d);
        //}
        public void UpdateBookingReservation(BookingReservation r)
        {
            iBookingRepository.UpdateBookingReservation(r);
        }
        public void UpdateBookingDetail(BookingDetail d)
        {
            iBookingRepository.UpdateBookingDetail(d);
        }
        public BookingReservation GetReservationById(int id)
        {
            return iBookingRepository.GetReservationById(id);
        }
        public BookingDetail GetDetailById(int id)
        {
            return iBookingRepository.GetDetailById(id);
        }
        public ObservableCollection<BookingReservation> GetReservations()
        {
            return iBookingRepository.GetReservations();
        }
        public ObservableCollection<BookingDetail> GetDetails()
        {
            return iBookingRepository.GetDetails();
        }
    }
}
