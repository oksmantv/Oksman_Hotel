namespace Oksman_Hotel
{
    partial class ChangeBooking
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtraBedBox = new System.Windows.Forms.CheckBox();
            this.RoomPrice = new System.Windows.Forms.Label();
            this.RoomSize = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GuestsBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.RoomNumber = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NoRoomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(215, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date:";
            // 
            // ExtraBedBox
            // 
            this.ExtraBedBox.AutoSize = true;
            this.ExtraBedBox.Location = new System.Drawing.Point(17, 141);
            this.ExtraBedBox.Name = "ExtraBedBox";
            this.ExtraBedBox.Size = new System.Drawing.Size(120, 21);
            this.ExtraBedBox.TabIndex = 38;
            this.ExtraBedBox.Text = "Add Extra Bed";
            this.ExtraBedBox.UseVisualStyleBackColor = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSize = true;
            this.RoomPrice.Location = new System.Drawing.Point(16, 115);
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Size = new System.Drawing.Size(44, 17);
            this.RoomPrice.TabIndex = 36;
            this.RoomPrice.Text = "Price:";
            // 
            // RoomSize
            // 
            this.RoomSize.AutoSize = true;
            this.RoomSize.Location = new System.Drawing.Point(16, 91);
            this.RoomSize.Name = "RoomSize";
            this.RoomSize.Size = new System.Drawing.Size(80, 17);
            this.RoomSize.TabIndex = 37;
            this.RoomSize.Text = "Room Size:";
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.Location = new System.Drawing.Point(16, 70);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(85, 17);
            this.RoomType.TabIndex = 35;
            this.RoomType.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Guests:";
            // 
            // GuestsBox
            // 
            this.GuestsBox.FormattingEnabled = true;
            this.GuestsBox.Location = new System.Drawing.Point(17, 185);
            this.GuestsBox.Name = "GuestsBox";
            this.GuestsBox.Size = new System.Drawing.Size(121, 24);
            this.GuestsBox.TabIndex = 33;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(16, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 17);
            this.NameLabel.TabIndex = 32;
            this.NameLabel.Text = "Name: ";
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Location = new System.Drawing.Point(241, 234);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(113, 38);
            this.CancelBookingButton.TabIndex = 31;
            this.CancelBookingButton.Text = "Cancel";
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 234);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(113, 38);
            this.SaveChangesButton.TabIndex = 30;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSize = true;
            this.RoomNumber.Location = new System.Drawing.Point(16, 50);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(103, 17);
            this.RoomNumber.TabIndex = 29;
            this.RoomNumber.Text = "Room Number:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(122, 234);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 38);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.Text = "Delete Booking";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NoRoomLabel
            // 
            this.NoRoomLabel.AutoSize = true;
            this.NoRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRoomLabel.ForeColor = System.Drawing.Color.Red;
            this.NoRoomLabel.Location = new System.Drawing.Point(177, 185);
            this.NoRoomLabel.Name = "NoRoomLabel";
            this.NoRoomLabel.Size = new System.Drawing.Size(0, 20);
            this.NoRoomLabel.TabIndex = 40;
            // 
            // ChangeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 284);
            this.Controls.Add(this.NoRoomLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExtraBedBox);
            this.Controls.Add(this.RoomPrice);
            this.Controls.Add(this.RoomSize);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GuestsBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ChangeBooking";
            this.Text = "ChangeBooking";
            this.Load += new System.EventHandler(this.ChangeBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ExtraBedBox;
        private System.Windows.Forms.Label RoomPrice;
        private System.Windows.Forms.Label RoomSize;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GuestsBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label NoRoomLabel;
    }
}