using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oksman_Hotel
{
    class AdjustData
    {

        public void AddCustomer(Customer C)
        {
            using (var Data = new HotelCaliforniaEntities())
            {
                Data.Customers.Add(C);
                Data.SaveChanges();

            }

        }
        public void BookARoom(Booking B)
        {

            using (var db = new HotelCaliforniaEntities())
            {
                db.Bookings.Add(B);
                db.SaveChanges();
            }

        }
        public void UpdateBooking(Booking B)
        {
            using (var db = new HotelCaliforniaEntities())
            {
                db.Bookings.AddOrUpdate(B);
                db.SaveChanges();
            }

        }

        public void DeleteBooking(Booking B)
        {      
            using (var db = new HotelCaliforniaEntities())
            {
                var Item = db.Bookings.SingleOrDefault(x => x.BookingID == B.BookingID);
                db.Bookings.Remove(Item);
                db.SaveChanges();
            }

        }
        public void CreateInvoice(Booking B)
        {
            
            var I = new Invoice();
            I.BookingID = B.BookingID;
            I.Complete = 0;
            I.BookedDate = DateTime.Now;

            using (var db = new HotelCaliforniaEntities())
            {
                db.Invoices.Add(I);
                db.SaveChanges();
            }

        }
    }
}
