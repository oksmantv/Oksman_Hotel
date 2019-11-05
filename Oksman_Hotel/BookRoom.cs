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
            RoomBox.ValueMember = "RoomID";
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
            if (RoomBox.SelectedValue == null) return;
            RoomBox.ValueMember = "RoomID";
            var Customer = new SearchCustomer();

            var B = new Booking();
            B.RoomID = int.Parse(RoomBox.SelectedValue.ToString());
            var Objekt = Customer.FindACustomer(_ID);
  
            B.CustomerID = int.Parse(Objekt.CustomerID.ToString());
            B.DateStart = DateTime1.Value;
            B.DateEnd = DateTime2.Value;

            B.BookARoom(B);
            this.Close();
        }

        private void RoomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Data = new GetData();

            var RoomInfo = Data.GetRoom(int.Parse(RoomBox.SelectedValue.ToString()));

            if (RoomInfo.RoomType == "1")
                RoomType.Text += "Single";
            else if (RoomInfo.RoomType == "2")
                RoomType.Text += "Double";

            RoomPrice.Text += RoomInfo.Price;
            RoomSize.Text += RoomInfo.
        }
    }
}
