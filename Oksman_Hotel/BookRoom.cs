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
    public partial class BookRoom : Form
    {
        public int _ID;
        public BookRoom(int id)
        {
            _ID = id;
            InitializeComponent();
        }

        private void CheckAvailableButton_Click(object sender, EventArgs e)
        {
            var Room = new GetData();
            RoomBox.DisplayMember = "RoomID";
            RoomBox.DataSource = Room.GetRoomsAvailable(DateTime1.Value, DateTime2.Value);

        }

        private void BookRoom_Load(object sender, EventArgs e)
        {

            var Customer = new SearchCustomer();
            var C = Customer.FindACustomer(_ID);
            NameLabel.Text += C.FullName;
        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookRoomButton_Click(object sender, EventArgs e)
        {
            RoomBox.ValueMember = "RoomID";
            var Customer = new SearchCustomer();

            var B = new Booking();
            B.RoomID = int.Parse(RoomBox.SelectedValue.ToString());
            B.CustomerID = int.Parse(Customer.FindACustomer(_ID).ToString());
            B.DateStart = DateTime1.Value;
            B.DateEnd = DateTime2.Value;

            B.BookARoom(B);
            this.Close();
        }
    }
}
