using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oksman_Hotel
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Customer = new Customer();
            Customer.FirstName = FirstNameBox.Text;
            Customer.LastName = LastNameBox.Text;
            Customer.PersonID = int.Parse(PersionIDBox.Text);

            var Data = new AdjustData();
            Data.AddCustomer(Customer);

            this.Close();

        }
    }
}
