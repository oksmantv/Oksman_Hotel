using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
Komplettering:

    2. Det skall gå att avboka ett rum eller ändra en bokning. Det skall gå att söka på ett
    datum eller datumintervall och antal personer och få fram alla lediga rum som
    motsvarar sökningen. 

        3. Till varje bokning skall det kopplas en betalning dvs en faktura. Applikationen skall
        kunna registrera en inkommen betalning på en faktura. Om inte en betalning
        registrerats inom 10 dagar efter att bokningen är gjord annulleras bokningen dvs den
        upphör att gälla. 


*/

namespace Oksman_Hotel
{
    public partial class Hotel_California : Form
    {
        private ChangeBooking Booking;
        public Hotel_California()
        {
            InitializeComponent();
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
            var PaymentCheck = new Payment();

            CustomerBox.DisplayMember = "FullName";
            CustomerBox.ValueMember = "CustomerID";
            CustomerBox.DataSource = Data.FindCustomer(CustomerText.Text);
        }

        private void CustomerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Data = new GetData();
            var Search = new SearchCustomer();
            

            BookingBox.DisplayMember = "BookingID";
            BookingBox.ValueMember = "BookingID";
            if(CustomerBox.SelectedValue == null)
                CustomerBox.ClearSelected();
            else
            { 
                Customer C = Search.FindACustomer(int.Parse(CustomerBox.SelectedValue.ToString()));
                BookingBox.DataSource = Data.GetBookings(C);
            }

        }

        private void PayBookingButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBookingButton_Click(object sender, EventArgs e)
        {
            if (BookingBox.SelectedValue == null) return;
            Booking = new ChangeBooking((int.Parse(BookingBox.SelectedValue.ToString())), (int.Parse(CustomerBox.SelectedValue.ToString())));
            Booking.FormClosed += Clear;
            Booking.Show();
        }
        private void Clear(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {

            BookingBox.DataSource = null;
            
        }

        private void ChangeCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerBox.SelectedValue == null) return;
            var Update = new ChangeCustomercs(int.Parse(CustomerBox.SelectedValue.ToString()));
            Update.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerBox.SelectedValue == null) return;
            var Delete = new AdjustData();
            var Get = new GetData();
            var Search = new SearchCustomer();
            Customer C = Search.FindACustomer(int.Parse(CustomerBox.SelectedValue.ToString()));
            var List = Get.GetBookings(C);

            if(List.Count > 0)
            {
                MessageBox.Show("Cannot Delete: Active Booking");

            }
            else
            {
                CustomerBox.ClearSelected();
                CustomerBox.DataSource = null;
                Delete.DeleteCustomer(C);

            }

        }
    }
}
