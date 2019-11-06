using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oksman_Hotel
{
    class GetData
    {
        public GetData()
        { 
        }
        public Room GetRoom(int Room_ID)
        {
            var R = new Room();
            using (var db = new HotelCaliforniaEntities())
            {
                R = (from r in db.Rooms where r.RoomID == Room_ID select r).FirstOrDefault();
            }
            return R;
        }

        public List<BookRoom.Beds> GetBeds(int number)
        {

            List<BookRoom.Beds> BedList = new List<BookRoom.Beds>();


            for (int i = 1; i < number + 1; i++)
            {
                var Bed = new BookRoom.Beds();
                Bed.Number = i;
                BedList.Add(Bed);

            }

            return BedList;
        }
        public List<Room> GetRooms ()
        {
            var Lista = new List<Room>();

            using (var db = new HotelCaliforniaEntities())
            {
                Lista = (from R in db.Rooms select R).ToList();

            }

            return Lista;

        }
        public bool CheckRoomAvailable(int CustomerID,Room R,DateTime Datum1,DateTime Datum2)
        {
            var StartDate = Datum1.Date;
            var EndDate = Datum2.Date;
            bool Booked=true;
            using (var db = new HotelCaliforniaEntities())
            {
                foreach (var Book in db.Bookings)
                {
                    if (((StartDate >= Book.DateStart && StartDate < Book.DateEnd) ||
                        (EndDate > Book.DateStart && EndDate <= Book.DateEnd)) ||
                        ((Book.DateStart >= StartDate && Book.DateStart < EndDate) ||
                        (Book.DateEnd > StartDate && Book.DateEnd <= EndDate)))
                    {
                        if((Book.CustomerID != CustomerID) && (Book.RoomID == R.RoomID))
                        { 
                            Booked = false;
                        }
                    }
                    else Booked = true;

                }       
            }
            return Booked;
        }
        public List<Room> GetRoomsAvailable (DateTime Datum1,DateTime Datum2)
        {
            var Lista = new List<Room>();
            var IntList = new List<int>();
            var Rooms = GetRooms();

            var StartDate = Datum1.Date;
            var EndDate = Datum2.Date;

            using (var db = new HotelCaliforniaEntities())
            {
                foreach (var Book in db.Bookings)
                {
                    if (((StartDate >= Book.DateStart && StartDate < Book.DateEnd) ||
                        (EndDate > Book.DateStart && EndDate <= Book.DateEnd)) ||
                        ((Book.DateStart >= StartDate && Book.DateStart < EndDate) ||
                        (Book.DateEnd > StartDate && Book.DateEnd <= EndDate)))
                    {
                        IntList.Add(Book.RoomID);
                    }

                }
                Lista = db.Rooms.Where(x => !IntList.Contains(x.RoomID)).ToList();
            }

            return Lista;
        }
        public List<Booking> GetBookings(Customer C)
        {
            var Lista = new List<Booking>();

            using (HotelCaliforniaEntities db = new HotelCaliforniaEntities())
            {

                Lista = (from b in db.Bookings
                         join c in db.Customers
                 on b.CustomerID equals c.CustomerID
                 where b.CustomerID == C.CustomerID
                 select b).ToList();

            }
            return Lista;
        }

        public Booking GetBooking(int id)
        {
            var B = new Booking();
            using (HotelCaliforniaEntities db = new HotelCaliforniaEntities())
            {
                
                B = (from b in db.Bookings
                         where b.BookingID == id
                         select b).FirstOrDefault();

            }
            return B;

        }

    }
}
