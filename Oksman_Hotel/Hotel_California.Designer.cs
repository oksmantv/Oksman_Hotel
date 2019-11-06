namespace Oksman_Hotel
{
    partial class Hotel_California
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerBox = new System.Windows.Forms.ListBox();
            this.BookingBox = new System.Windows.Forms.ListBox();
            this.CustomerText = new System.Windows.Forms.TextBox();
            this.PayBookingButton = new System.Windows.Forms.Button();
            this.ChangeBookingButton = new System.Windows.Forms.Button();
            this.BookRoom_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(237, 11);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search Customer";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(36, 242);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(141, 39);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.ItemHeight = 16;
            this.CustomerBox.Location = new System.Drawing.Point(36, 77);
            this.CustomerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(223, 148);
            this.CustomerBox.TabIndex = 2;
            this.CustomerBox.SelectedIndexChanged += new System.EventHandler(this.CustomerBox_SelectedIndexChanged);
            // 
            // BookingBox
            // 
            this.BookingBox.FormattingEnabled = true;
            this.BookingBox.ItemHeight = 16;
            this.BookingBox.Location = new System.Drawing.Point(278, 77);
            this.BookingBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookingBox.Name = "BookingBox";
            this.BookingBox.Size = new System.Drawing.Size(137, 148);
            this.BookingBox.TabIndex = 3;
            // 
            // CustomerText
            // 
            this.CustomerText.Location = new System.Drawing.Point(36, 12);
            this.CustomerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.Size = new System.Drawing.Size(196, 22);
            this.CustomerText.TabIndex = 4;
            // 
            // PayBookingButton
            // 
            this.PayBookingButton.Location = new System.Drawing.Point(278, 242);
            this.PayBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayBookingButton.Name = "PayBookingButton";
            this.PayBookingButton.Size = new System.Drawing.Size(137, 39);
            this.PayBookingButton.TabIndex = 6;
            this.PayBookingButton.Text = "Pay Booking";
            this.PayBookingButton.UseVisualStyleBackColor = true;
            this.PayBookingButton.Click += new System.EventHandler(this.PayBookingButton_Click);
            // 
            // ChangeBookingButton
            // 
            this.ChangeBookingButton.Location = new System.Drawing.Point(278, 296);
            this.ChangeBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeBookingButton.Name = "ChangeBookingButton";
            this.ChangeBookingButton.Size = new System.Drawing.Size(137, 39);
            this.ChangeBookingButton.TabIndex = 7;
            this.ChangeBookingButton.Text = "Change Booking";
            this.ChangeBookingButton.UseVisualStyleBackColor = true;
            this.ChangeBookingButton.Click += new System.EventHandler(this.ChangeBookingButton_Click);
            // 
            // BookRoom_Button
            // 
            this.BookRoom_Button.Location = new System.Drawing.Point(36, 296);
            this.BookRoom_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookRoom_Button.Name = "BookRoom_Button";
            this.BookRoom_Button.Size = new System.Drawing.Size(141, 39);
            this.BookRoom_Button.TabIndex = 8;
            this.BookRoom_Button.Text = "Book Room";
            this.BookRoom_Button.UseVisualStyleBackColor = true;
            this.BookRoom_Button.Click += new System.EventHandler(this.BookRoom_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bookings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customers:";
            // 
            // Hotel_California
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookRoom_Button);
            this.Controls.Add(this.ChangeBookingButton);
            this.Controls.Add(this.PayBookingButton);
            this.Controls.Add(this.CustomerText);
            this.Controls.Add(this.BookingBox);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.SearchButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hotel_California";
            this.Text = "Hotel California";
            this.Load += new System.EventHandler(this.Hotel_California_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ListBox CustomerBox;
        private System.Windows.Forms.ListBox BookingBox;
        private System.Windows.Forms.TextBox CustomerText;
        private System.Windows.Forms.Button PayBookingButton;
        private System.Windows.Forms.Button ChangeBookingButton;
        private System.Windows.Forms.Button BookRoom_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

