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

        public List<Room> GetRooms ()
        {
            var Lista = new List<Room>();

            using (var db = new HotelCaliforniaEntities())
            {
                Lista = (from R in db.Rooms select R).ToList();

            }

            return Lista;

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

                //Lista = 
                //(from B in db.Bookings
                //where !(StartDate >= B.DateStart && EndDate <= B.DateEnd) && !(B.DateEnd >= StartDate && B.DateStart <= EndDate)
                // select B).ToList();

            }

            return Lista;
        }



    }
}
