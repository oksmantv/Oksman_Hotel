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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }
        public bool BoolValue { get; set; }

        private void YesButton_Click(object sender, EventArgs e)
        {
            BoolValue = true;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            BoolValue = false;
            this.Close();
        }
    }
}
