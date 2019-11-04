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
    public partial class Hotel_California : Form
    {
        public Hotel_California()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var Add = new AddCustomer();
            Add.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
    
            var Data = new SearchCustomer();

            CustomerBox.DisplayMember = "FullName";
            CustomerBox.ValueMember = "CustomerID";
            CustomerBox.DataSource = Data.FindCustomer(CustomerText.Text);

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (CustomerBox.SelectedValue == null) return;
            CustomerBox.DisplayMember = "FirstName";
            CustomerBox.ValueMember = "CustomerID";

            var Book = new BookRoom(int.Parse(CustomerBox.SelectedValue.ToString()));
            Book.Show();
        }
    }
}
