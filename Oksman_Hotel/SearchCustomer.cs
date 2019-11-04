using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oksman_Hotel
{
    public partial class SearchCustomer
    {
        public Customer FindACustomer(int id)
        {
            var C = new Customer();

            using (HotelCaliforniaEntities db = new HotelCaliforniaEntities())
            {
                C = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();            
            }

            return C;
        }
        public List<Customer> FindCustomer(string name)
        {
           using (HotelCaliforniaEntities db = new HotelCaliforniaEntities())
           {

                List < Customer > Lista = new List<Customer>();

                if (name.Length < 1)
                {
                  Lista = (from c in db.Customers select c).ToList();
                }
                else
                {
                    Lista = (from c in db.Customers
                             where c.FirstName.Contains(name)
                             select c).ToList();
                }

                return Lista;


            }


        }
    }
}
