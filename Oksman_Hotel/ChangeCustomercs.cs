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
    public partial class ChangeCustomercs : Form
    {
        private int _ID;
        public ChangeCustomercs(int CustomerID)
        {
            _ID = CustomerID;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeCustomercs_Load(object sender, EventArgs e)
        {
            var Get = new SearchCustomer();
            Customer C = Get.FindACustomer(_ID);

            FirstNameBox.Text = C.FirstName;
            LastNameBox.Text = C.LastName;
            PersionIDBox.Text = C.PersonID.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            var Update = new AdjustData();
            var Search = new SearchCustomer();
            Customer C = Search.FindACustomer(_ID);
            C.FirstName = FirstNameBox.Text;
            C.LastName = LastNameBox.Text;
            C.PersonID = int.Parse(PersionIDBox.Text);

            if (Search.CheckPersonID(C))
                MessageBox.Show("ID Already Exists");
            else
            {

                Update.ChangeCustomer(C);
                this.Close();
            }


        }
    }
}
