namespace VP_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TapeName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RecordType = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RTFText = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RecievementDate = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.AuthorPhoto = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Studio = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.StudioAddress = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.Director = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.TapeId = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxDropDownItems = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(333, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // TapeName
            // 
            this.TapeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TapeName.Enabled = false;
            this.TapeName.Location = new System.Drawing.Point(179, 100);
            this.TapeName.Margin = new System.Windows.Forms.Padding(4);
            this.TapeName.Name = "TapeName";
            this.TapeName.ReadOnly = true;
            this.TapeName.Size = new System.Drawing.Size(156, 24);
            this.TapeName.TabIndex = 1;
            this.TapeName.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Name:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(15, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Record Type:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RecordType
            // 
            this.RecordType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordType.Enabled = false;
            this.RecordType.Location = new System.Drawing.Point(179, 132);
            this.RecordType.Margin = new System.Windows.Forms.Padding(4);
            this.RecordType.Name = "RecordType";
            this.RecordType.ReadOnly = true;
            this.RecordType.Size = new System.Drawing.Size(156, 24);
            this.RecordType.TabIndex = 3;
            this.RecordType.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(98, 165);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(156, 24);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "RTF Text:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RTFText
            // 
            this.RTFText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTFText.Enabled = false;
            this.RTFText.Location = new System.Drawing.Point(59, 198);
            this.RTFText.Margin = new System.Windows.Forms.Padding(4);
            this.RTFText.Multiline = true;
            this.RTFText.Name = "RTFText";
            this.RTFText.ReadOnly = true;
            this.RTFText.Size = new System.Drawing.Size(276, 81);
            this.RTFText.TabIndex = 5;
            this.RTFText.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(15, 291);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(156, 24);
            this.textBox5.TabIndex = 8;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Recievement Date:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RecievementDate
            // 
            this.RecievementDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecievementDate.Enabled = false;
            this.RecievementDate.Location = new System.Drawing.Point(179, 291);
            this.RecievementDate.Margin = new System.Windows.Forms.Padding(4);
            this.RecievementDate.Name = "RecievementDate";
            this.RecievementDate.ReadOnly = true;
            this.RecievementDate.Size = new System.Drawing.Size(148, 24);
            this.RecievementDate.TabIndex = 7;
            this.RecievementDate.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(15, 324);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(156, 24);
            this.textBox4.TabIndex = 10;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Creation Date:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreationDate
            // 
            this.CreationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreationDate.Enabled = false;
            this.CreationDate.Location = new System.Drawing.Point(179, 324);
            this.CreationDate.Margin = new System.Windows.Forms.Padding(4);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Size = new System.Drawing.Size(148, 24);
            this.CreationDate.TabIndex = 9;
            this.CreationDate.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(15, 356);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(156, 24);
            this.textBox6.TabIndex = 12;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Length:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Length
            // 
            this.Length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Length.Enabled = false;
            this.Length.Location = new System.Drawing.Point(179, 356);
            this.Length.Margin = new System.Windows.Forms.Padding(4);
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Size = new System.Drawing.Size(156, 24);
            this.Length.TabIndex = 11;
            this.Length.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(396, 100);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(156, 24);
            this.textBox7.TabIndex = 14;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Author Name:";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AuthorName
            // 
            this.AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorName.Enabled = false;
            this.AuthorName.Location = new System.Drawing.Point(560, 100);
            this.AuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Size = new System.Drawing.Size(156, 24);
            this.AuthorName.TabIndex = 13;
            this.AuthorName.TabStop = false;
            // 
            // AuthorPhoto
            // 
            this.AuthorPhoto.Location = new System.Drawing.Point(396, 132);
            this.AuthorPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorPhoto.Name = "AuthorPhoto";
            this.AuthorPhoto.Size = new System.Drawing.Size(320, 184);
            this.AuthorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AuthorPhoto.TabIndex = 15;
            this.AuthorPhoto.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(396, 324);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(156, 24);
            this.textBox8.TabIndex = 17;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Address:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Adress
            // 
            this.Adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Adress.Enabled = false;
            this.Adress.Location = new System.Drawing.Point(560, 324);
            this.Adress.Margin = new System.Windows.Forms.Padding(4);
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Size = new System.Drawing.Size(156, 24);
            this.Adress.TabIndex = 16;
            this.Adress.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(755, 100);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(156, 24);
            this.textBox9.TabIndex = 19;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Studio:";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Studio
            // 
            this.Studio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Studio.Enabled = false;
            this.Studio.Location = new System.Drawing.Point(919, 100);
            this.Studio.Margin = new System.Windows.Forms.Padding(4);
            this.Studio.Name = "Studio";
            this.Studio.ReadOnly = true;
            this.Studio.Size = new System.Drawing.Size(156, 24);
            this.Studio.TabIndex = 18;
            this.Studio.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(755, 132);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(156, 24);
            this.textBox10.TabIndex = 21;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Studio Address:";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StudioAddress
            // 
            this.StudioAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudioAddress.Enabled = false;
            this.StudioAddress.Location = new System.Drawing.Point(919, 132);
            this.StudioAddress.Margin = new System.Windows.Forms.Padding(4);
            this.StudioAddress.Name = "StudioAddress";
            this.StudioAddress.ReadOnly = true;
            this.StudioAddress.Size = new System.Drawing.Size(156, 24);
            this.StudioAddress.TabIndex = 20;
            this.StudioAddress.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(755, 165);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(156, 24);
            this.textBox11.TabIndex = 23;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Studio Director:";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Director
            // 
            this.Director.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Director.Enabled = false;
            this.Director.Location = new System.Drawing.Point(919, 165);
            this.Director.Margin = new System.Windows.Forms.Padding(4);
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Size = new System.Drawing.Size(156, 24);
            this.Director.TabIndex = 22;
            this.Director.TabStop = false;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(755, 198);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(156, 24);
            this.textBox12.TabIndex = 25;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Phone Number:";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber.Enabled = false;
            this.PhoneNumber.Location = new System.Drawing.Point(919, 198);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Size = new System.Drawing.Size(156, 24);
            this.PhoneNumber.TabIndex = 24;
            this.PhoneNumber.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(15, 389);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(156, 24);
            this.textBox13.TabIndex = 27;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Tape Number:";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TapeId
            // 
            this.TapeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TapeId.Enabled = false;
            this.TapeId.Location = new System.Drawing.Point(179, 389);
            this.TapeId.Margin = new System.Windows.Forms.Padding(4);
            this.TapeId.Name = "TapeId";
            this.TapeId.ReadOnly = true;
            this.TapeId.Size = new System.Drawing.Size(156, 24);
            this.TapeId.TabIndex = 26;
            this.TapeId.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(396, 15);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.MaxDropDownItems = 50;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(319, 33);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextUpdate += new System.EventHandler(this.comboBox2_TextUpdate);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Edit Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.TapeId);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.StudioAddress);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Studio);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.AuthorPhoto);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.RecievementDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RTFText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RecordType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TapeName);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private TextBox TapeName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox RecordType;
        private TextBox textBox3;
        private TextBox RTFText;
        private TextBox textBox5;
        private TextBox RecievementDate;
        private TextBox textBox4;
        private TextBox CreationDate;
        private TextBox textBox6;
        private TextBox Length;
        private TextBox textBox7;
        private TextBox AuthorName;
        private PictureBox AuthorPhoto;
        private TextBox textBox8;
        private TextBox Adress;
        private TextBox textBox9;
        private TextBox Studio;
        private TextBox textBox10;
        private TextBox StudioAddress;
        private TextBox textBox11;
        private TextBox Director;
        private TextBox textBox12;
        private TextBox PhoneNumber;
        private TextBox textBox13;
        private TextBox TapeId;
        private ComboBox comboBox2;
        private Button button1;
    }
}