namespace Oksman_Hotel
{
    partial class BookRoom
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
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.BookRoomButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckAvailableButton = new System.Windows.Forms.Button();
            this.RoomBox = new System.Windows.Forms.ListBox();
            this.DateTime2 = new System.Windows.Forms.DateTimePicker();
            this.DateTime1 = new System.Windows.Forms.DateTimePicker();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GuestsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.Label();
            this.RoomSize = new System.Windows.Forms.Label();
            this.ExtraBedBox = new System.Windows.Forms.CheckBox();
            this.RoomPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Location = new System.Drawing.Point(163, 304);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(104, 38);
            this.CancelBookingButton.TabIndex = 19;
            this.CancelBookingButton.Text = "Cancel";
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // BookRoomButton
            // 
            this.BookRoomButton.Location = new System.Drawing.Point(30, 304);
            this.BookRoomButton.Name = "BookRoomButton";
            this.BookRoomButton.Size = new System.Drawing.Size(104, 38);
            this.BookRoomButton.TabIndex = 18;
            this.BookRoomButton.Text = "Book Room";
            this.BookRoomButton.UseVisualStyleBackColor = true;
            this.BookRoomButton.Click += new System.EventHandler(this.BookRoomButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Available Rooms:";
            // 
            // CheckAvailableButton
            // 
            this.CheckAvailableButton.Location = new System.Drawing.Point(307, 157);
            this.CheckAvailableButton.Name = "CheckAvailableButton";
            this.CheckAvailableButton.Size = new System.Drawing.Size(140, 27);
            this.CheckAvailableButton.TabIndex = 16;
            this.CheckAvailableButton.Text = "Check Availability";
            this.CheckAvailableButton.UseVisualStyleBackColor = true;
            this.CheckAvailableButton.Click += new System.EventHandler(this.CheckAvailableButton_Click);
            // 
            // RoomBox
            // 
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.ItemHeight = 16;
            this.RoomBox.Location = new System.Drawing.Point(13, 61);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(254, 68);
            this.RoomBox.TabIndex = 15;
            this.RoomBox.SelectedIndexChanged += new System.EventHandler(this.RoomBox_SelectedIndexChanged);
            // 
            // DateTime2
            // 
            this.DateTime2.Location = new System.Drawing.Point(307, 115);
            this.DateTime2.Name = "DateTime2";
            this.DateTime2.Size = new System.Drawing.Size(147, 22);
            this.DateTime2.TabIndex = 14;
            // 
            // DateTime1
            // 
            this.DateTime1.Location = new System.Drawing.Point(307, 87);
            this.DateTime1.MinDate = new System.DateTime(2019, 11, 4, 12, 48, 16, 0);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.Size = new System.Drawing.Size(145, 22);
            this.DateTime1.TabIndex = 13;
            this.DateTime1.Value = new System.DateTime(2019, 11, 4, 12, 48, 16, 0);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 17);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name: ";
            // 
            // GuestsBox
            // 
            this.GuestsBox.FormattingEnabled = true;
            this.GuestsBox.Location = new System.Drawing.Point(13, 256);
            this.GuestsBox.Name = "GuestsBox";
            this.GuestsBox.Size = new System.Drawing.Size(121, 24);
            this.GuestsBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Guests:";
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.Location = new System.Drawing.Point(12, 141);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(85, 17);
            this.RoomType.TabIndex = 25;
            this.RoomType.Text = "Room Type:";
            // 
            // RoomSize
            // 
            this.RoomSize.AutoSize = true;
            this.RoomSize.Location = new System.Drawing.Point(12, 162);
            this.RoomSize.Name = "RoomSize";
            this.RoomSize.Size = new System.Drawing.Size(80, 17);
            this.RoomSize.TabIndex = 26;
            this.RoomSize.Text = "Room Size:";
            // 
            // ExtraBedBox
            // 
            this.ExtraBedBox.AutoSize = true;
            this.ExtraBedBox.Location = new System.Drawing.Point(13, 212);
            this.ExtraBedBox.Name = "ExtraBedBox";
            this.ExtraBedBox.Size = new System.Drawing.Size(120, 21);
            this.ExtraBedBox.TabIndex = 27;
            this.ExtraBedBox.Text = "Add Extra Bed";
            this.ExtraBedBox.UseVisualStyleBackColor = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSize = true;
            this.RoomPrice.Location = new System.Drawing.Point(12, 186);
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Size = new System.Drawing.Size(44, 17);
            this.RoomPrice.TabIndex = 26;
            this.RoomPrice.Text = "Price:";
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 359);
            this.Controls.Add(this.ExtraBedBox);
            this.Controls.Add(this.RoomPrice);
            this.Controls.Add(this.RoomSize);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuestsBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.BookRoomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckAvailableButton);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.DateTime2);
            this.Controls.Add(this.DateTime1);
            this.Name = "BookRoom";
            this.Text = "BookRoom";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button BookRoomButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckAvailableButton;
        private System.Windows.Forms.ListBox RoomBox;
        private System.Windows.Forms.DateTimePicker DateTime2;
        private System.Windows.Forms.DateTimePicker DateTime1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox GuestsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label RoomSize;
        private System.Windows.Forms.CheckBox ExtraBedBox;
        private System.Windows.Forms.Label RoomPrice;
    }
}