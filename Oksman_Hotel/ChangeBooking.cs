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
    public partial class ChangeBooking : Form
    {
        private int _ID;
        private int Customer_ID;
        int BedsCount;
        Confirm Deleted;
        public ChangeBooking(int id, int customerID)
        {
            Customer_ID = customerID;
            _ID = id;
            InitializeComponent();
        }

        private void ChangeBooking_Load(object sender, EventArgs e)
        {
            var Data = new GetData();
            var Customer = new SearchCustomer();
            var Name = Customer.FindACustomer(Customer_ID);
            ExtraBedBox.Checked = false;
            NameLabel.Text = Name.FullName.ToString();
            

            var BookingInfo = Data.GetBooking(_ID);
            var RoomInfo = Data.GetRoom(int.Parse(BookingInfo.RoomID.ToString()));
            RoomNumber.Text += int.Parse(RoomInfo.RoomID.ToString());

            if (RoomInfo.RoomType == "1")
                RoomType.Text += "Single";
            else if (RoomInfo.RoomType == "2")
                RoomType.Text += "Double";

            if (RoomInfo.RoomType == "2" && BookingInfo.Guests > 2)
                ExtraBedBox.Checked = true;

            RoomPrice.Text += RoomInfo.Price;
            RoomSize.Text += RoomInfo.Size;

            if (RoomInfo.Size < 35) ExtraBedBox.Enabled = false;
            else ExtraBedBox.Enabled = true;
            BedsCount = RoomInfo.Beds;
            List<BookRoom.Beds> BedList = new List<BookRoom.Beds>();
            BedList = Data.GetBeds(RoomInfo.Beds);

            GuestsBox.DisplayMember = "Number";
            GuestsBox.ValueMember = "Number";
            GuestsBox.DataSource = BedList;
            GuestsBox.SelectedValue = BookingInfo.Guests;

            dateTimePicker1.Value = BookingInfo.DateStart;
            dateTimePicker2.Value = BookingInfo.DateEnd;

        }

        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //var B = new Booking();
            var Get = new GetData();
            var Add = new AdjustData();

            Booking B = Get.GetBooking(_ID);
            Room R = Get.GetRoom(int.Parse(B.RoomID.ToString()));
            if(Get.CheckRoomAvailable(Customer_ID,R, dateTimePicker1.Value, dateTimePicker2.Value))
            {
                B.DateStart = dateTimePicker1.Value;
                B.DateEnd = dateTimePicker2.Value;
                B.Guests = int.Parse(GuestsBox.SelectedValue.ToString());

                Add.UpdateBooking(B);
                this.Close();
            }
            else { NoRoomLabel.Text = "Room not available."; }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Deleted = new Confirm();
            Deleted.FormClosed += Delete;
            Deleted.Show();

        }

        private void Delete(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (Deleted.BoolValue)
            {

                var Get = new GetData();
                var Add = new AdjustData();

                Booking B = Get.GetBooking(_ID);
                Add.DeleteBooking(B);
                this.Close();

            }

        }
    }
}
