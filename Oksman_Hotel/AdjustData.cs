using System;
using System.Collections.Generic;
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

    }
}
