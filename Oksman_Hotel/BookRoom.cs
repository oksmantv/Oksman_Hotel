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
        string RoomTypeOG;
        string RoomPriceOG;
        string RoomSizeOG;
        int BedsCount;
        public BookRoom(int id)
        {
            _ID = id;
            InitializeComponent();
        }

        public class Beds
        {
            public int Number { get; set; }
        }

        private void CheckAvailableButton_Click(object sender, EventArgs e)
        {
            var GetRoom = new GetData();
            RoomBox.DisplayMember = "RoomID";
            RoomBox.ValueMember = "RoomID";
            List<Room> AvailableRooms = GetRoom.GetRoomsAvailable(DateTime1.Value, DateTime2.Value);

            if (AvailableRooms.Count < 1)
                NoRoomLabel.Text = "0 Rooms Available!";
            else NoRoomLabel.Text = "";

            RoomBox.DataSource = AvailableRooms;

        }

        private void BookRoom_Load(object sender, EventArgs e)
        {
            RoomTypeOG = RoomType.Text;
            RoomPriceOG = RoomPrice.Text;
            RoomSizeOG = RoomSize.Text;

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
            var Add = new AdjustData();
            B.RoomID = int.Parse(RoomBox.SelectedValue.ToString());
            var Objekt = Customer.FindACustomer(_ID);
  
            B.CustomerID = int.Parse(Objekt.CustomerID.ToString());
            B.DateStart = DateTime1.Value;
            B.DateEnd = DateTime2.Value;
            B.Guests = int.Parse(GuestsBox.SelectedValue.ToString());

            Add.BookARoom(B);
            Add.CreateInvoice(B);
            
            this.Close();
        }

        private void RoomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Data = new GetData();
            ExtraBedBox.Checked = false;

            var RoomInfo = Data.GetRoom(int.Parse(RoomBox.SelectedValue.ToString()));

            if (RoomInfo.RoomType == "1")
                RoomType.Text = RoomTypeOG + "Single";
            else if (RoomInfo.RoomType == "2")
                RoomType.Text = RoomTypeOG + "Double";

            RoomPrice.Text = RoomPriceOG + RoomInfo.Price;
            RoomSize.Text = RoomSizeOG + RoomInfo.Size;

            if (RoomInfo.Size < 35) ExtraBedBox.Enabled = false;
            else ExtraBedBox.Enabled = true;
            BedsCount = RoomInfo.Beds;
            List<Beds> BedList = new List<Beds>();
            BedList = Data.GetBeds(RoomInfo.Beds);

            GuestsBox.DisplayMember = "Number";
            GuestsBox.ValueMember = "Number";
            GuestsBox.DataSource = BedList;

        }

        private void GuestsBox_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void ExtraBedBox_CheckedChanged(object sender, EventArgs e)
        {

            if (ExtraBedBox.Checked == true)
            {
                var GetBeds = new GetData();
                List<Beds> BedList = GetBeds.GetBeds(BedsCount + 1);

                GuestsBox.DisplayMember = "Number";
                GuestsBox.ValueMember = "Number";
                GuestsBox.DataSource = BedList;
            }
            else
            {
                var GetBeds = new GetData();
                List<Beds> BedList = GetBeds.GetBeds(BedsCount);

                GuestsBox.DisplayMember = "Number";
                GuestsBox.ValueMember = "Number";
                GuestsBox.DataSource = BedList;

            }

        }
    }
}
