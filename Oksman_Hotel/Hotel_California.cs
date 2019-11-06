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



        private void Hotel_California_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            var Add = new AddCustomer();
            Add.Show();
        }

        private void BookRoom_Button_Click(object sender, EventArgs e)
        {
            if (CustomerBox.SelectedValue == null) return;
            var Book = new BookRoom(int.Parse(CustomerBox.SelectedValue.ToString()));
            Book.Show();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var Data = new SearchCustomer();

            CustomerBox.DisplayMember = "FullName";
            CustomerBox.ValueMember = "CustomerID";
            CustomerBox.DataSource = Data.FindCustomer(CustomerText.Text);
        }

        private void CustomerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Data = new GetData();
            var Search = new SearchCustomer();
            Customer C = Search.FindACustomer(int.Parse(CustomerBox.SelectedValue.ToString()));

            BookingBox.DisplayMember = "BookingID";
            BookingBox.ValueMember = "BookingID";
            BookingBox.DataSource = Data.GetBookings(C);

        }

        private void PayBookingButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBookingButton_Click(object sender, EventArgs e)
        {
            var Book = new ChangeBooking((int.Parse(BookingBox.SelectedValue.ToString())), (int.Parse(CustomerBox.SelectedValue.ToString())));
            Book.Show();
        }
    }
}
