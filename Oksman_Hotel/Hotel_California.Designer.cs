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
            this.DeleteBookingButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(238, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 22);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search Customer";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(36, 332);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(141, 39);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.ItemHeight = 16;
            this.CustomerBox.Location = new System.Drawing.Point(36, 52);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(240, 260);
            this.CustomerBox.TabIndex = 2;
            // 
            // BookingBox
            // 
            this.BookingBox.FormattingEnabled = true;
            this.BookingBox.ItemHeight = 16;
            this.BookingBox.Location = new System.Drawing.Point(314, 52);
            this.BookingBox.Name = "BookingBox";
            this.BookingBox.Size = new System.Drawing.Size(244, 260);
            this.BookingBox.TabIndex = 3;
            // 
            // CustomerText
            // 
            this.CustomerText.Location = new System.Drawing.Point(36, 12);
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.Size = new System.Drawing.Size(196, 22);
            this.CustomerText.TabIndex = 4;
            // 
            // PayBookingButton
            // 
            this.PayBookingButton.Location = new System.Drawing.Point(417, 332);
            this.PayBookingButton.Name = "PayBookingButton";
            this.PayBookingButton.Size = new System.Drawing.Size(141, 39);
            this.PayBookingButton.TabIndex = 6;
            this.PayBookingButton.Text = "Pay Booking";
            this.PayBookingButton.UseVisualStyleBackColor = true;
            // 
            // DeleteBookingButton
            // 
            this.DeleteBookingButton.Location = new System.Drawing.Point(417, 386);
            this.DeleteBookingButton.Name = "DeleteBookingButton";
            this.DeleteBookingButton.Size = new System.Drawing.Size(141, 39);
            this.DeleteBookingButton.TabIndex = 7;
            this.DeleteBookingButton.Text = "Delete Booking";
            this.DeleteBookingButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Book Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Hotel_California
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBookingButton);
            this.Controls.Add(this.PayBookingButton);
            this.Controls.Add(this.CustomerText);
            this.Controls.Add(this.BookingBox);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.SearchButton);
            this.Name = "Hotel_California";
            this.Text = "Hotel California";
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
        private System.Windows.Forms.Button DeleteBookingButton;
        private System.Windows.Forms.Button button1;
    }
}

