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
        public void ChangeCustomer(Customer C)
        {
            using (var Data = new HotelCaliforniaEntities())
            {
                var Item = Data.Customers.First(a => a.CustomerID == C.CustomerID);
                Item.FirstName = C.FirstName;
                Item.LastName = C.LastName;
                Item.PersonID = C.PersonID;
                Data.SaveChanges();

            }

        }
        public void DeleteCustomer(Customer C)
        {
            using (var db = new HotelCaliforniaEntities())
            {
                var Item = db.Customers.SingleOrDefault(x => x.CustomerID == C.CustomerID);
                db.Customers.Remove(Item);
                db.SaveChanges();

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

                var Invoice = db.Invoices.SingleOrDefault(x => x.BookingID == B.BookingID);

                if(Invoice == null)
                {
                    db.SaveChanges();
                }
                else
                {
                    db.Invoices.Remove(Invoice);
                    db.SaveChanges();
                }
            }
        }
        public void CreateInvoice(Booking B)
        {
            var Get = new GetData();
            Room R = Get.GetRoom(int.Parse(B.RoomID.ToString()));
            decimal Price = decimal.Parse(((B.DateEnd - B.DateStart).TotalDays * R.Price).ToString());
            var I = new Invoice();
            I.BookingID = B.BookingID;
            I.Complete = 0;
            I.BookedDate = DateTime.Now;
            I.TotalPrice = Price;

            using (var db = new HotelCaliforniaEntities())
            {
                db.Invoices.Add(I);
                db.SaveChanges();
            }

        }
    }
}
