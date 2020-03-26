namespace MyBikes.client
{
    partial class MainForm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxMade = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labeSuspension = new System.Windows.Forms.Label();
            this.comboBoxSuspension = new System.Windows.Forms.ComboBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelSeatHeight = new System.Windows.Forms.Label();
            this.textBoxSeatHeight = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSearchSerial = new System.Windows.Forms.Label();
            this.textBoxSearchSerial = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonSaveBin = new System.Windows.Forms.Button();
            this.buttonLoadBin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDisplayMountainBikes = new System.Windows.Forms.Button();
            this.buttonDisplayRoadBikes = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(376, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mountain Bikes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(602, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Road Bikes";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Number:";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(111, 39);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(122, 22);
            this.textBoxSerialNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Made:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(451, 42);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(50, 17);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Model:";
            // 
            // comboBoxMade
            // 
            this.comboBoxMade.FormattingEnabled = true;
            this.comboBoxMade.Location = new System.Drawing.Point(304, 39);
            this.comboBoxMade.Name = "comboBoxMade";
            this.comboBoxMade.Size = new System.Drawing.Size(124, 24);
            this.comboBoxMade.TabIndex = 7;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(507, 39);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(124, 24);
            this.comboBoxModel.TabIndex = 8;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(641, 44);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(97, 17);
            this.labelSpeed.TabIndex = 9;
            this.labelSpeed.Text = "Speed (km/h):";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(744, 41);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(122, 22);
            this.textBoxSpeed.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Color:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(934, 42);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(124, 24);
            this.comboBoxColor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Made Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "/";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(340, 107);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(54, 22);
            this.textBoxDay.TabIndex = 17;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(432, 107);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(54, 22);
            this.textBoxMonth.TabIndex = 18;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(536, 107);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(54, 22);
            this.textBoxYear.TabIndex = 19;
            // 
            // labeSuspension
            // 
            this.labeSuspension.AutoSize = true;
            this.labeSuspension.Location = new System.Drawing.Point(23, 152);
            this.labeSuspension.Name = "labeSuspension";
            this.labeSuspension.Size = new System.Drawing.Size(86, 17);
            this.labeSuspension.TabIndex = 20;
            this.labeSuspension.Text = "Suspension:";
            // 
            // comboBoxSuspension
            // 
            this.comboBoxSuspension.FormattingEnabled = true;
            this.comboBoxSuspension.Location = new System.Drawing.Point(111, 149);
            this.comboBoxSuspension.Name = "comboBoxSuspension";
            this.comboBoxSuspension.Size = new System.Drawing.Size(124, 24);
            this.comboBoxSuspension.TabIndex = 21;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(23, 184);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 17);
            this.labelHeight.TabIndex = 22;
            this.labelHeight.Text = "Height: ";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(111, 184);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(122, 22);
            this.textBoxHeight.TabIndex = 23;
            // 
            // labelSeatHeight
            // 
            this.labelSeatHeight.AutoSize = true;
            this.labelSeatHeight.Location = new System.Drawing.Point(628, 152);
            this.labelSeatHeight.Name = "labelSeatHeight";
            this.labelSeatHeight.Size = new System.Drawing.Size(86, 17);
            this.labelSeatHeight.TabIndex = 24;
            this.labelSeatHeight.Text = "Seat Height:";
            // 
            // textBoxSeatHeight
            // 
            this.textBoxSeatHeight.Location = new System.Drawing.Point(720, 149);
            this.textBoxSeatHeight.Name = "textBoxSeatHeight";
            this.textBoxSeatHeight.Size = new System.Drawing.Size(122, 22);
            this.textBoxSeatHeight.TabIndex = 25;
            this.textBoxSeatHeight.TextChanged += new System.EventHandler(this.textBoxSeatHeight_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(60, 241);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 46);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(201, 242);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(83, 46);
            this.buttonDisplay.TabIndex = 27;
            this.buttonDisplay.Text = "Display All";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(655, 242);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 46);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(783, 241);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(83, 46);
            this.buttonRemove.TabIndex = 29;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 334);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(754, 196);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Serial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Made";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Color";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Suspension";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Height";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(599, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Seat Height";
            // 
            // labelSearchSerial
            // 
            this.labelSearchSerial.AutoSize = true;
            this.labelSearchSerial.Location = new System.Drawing.Point(815, 338);
            this.labelSearchSerial.Name = "labelSearchSerial";
            this.labelSearchSerial.Size = new System.Drawing.Size(110, 17);
            this.labelSearchSerial.TabIndex = 40;
            this.labelSearchSerial.Text = "Searial Number:";
            // 
            // textBoxSearchSerial
            // 
            this.textBoxSearchSerial.Location = new System.Drawing.Point(948, 335);
            this.textBoxSearchSerial.Name = "textBoxSearchSerial";
            this.textBoxSearchSerial.Size = new System.Drawing.Size(137, 22);
            this.textBoxSearchSerial.TabIndex = 41;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(962, 382);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 42);
            this.buttonSearch.TabIndex = 42;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(798, 438);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(127, 24);
            this.buttonSaveXml.TabIndex = 43;
            this.buttonSaveXml.Text = "Save to Xml file";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.buttonSaveXml_Click);
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(799, 473);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(125, 29);
            this.buttonLoadXml.TabIndex = 44;
            this.buttonLoadXml.Text = "Load Xml file";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonSaveBin
            // 
            this.buttonSaveBin.Location = new System.Drawing.Point(960, 436);
            this.buttonSaveBin.Name = "buttonSaveBin";
            this.buttonSaveBin.Size = new System.Drawing.Size(124, 25);
            this.buttonSaveBin.TabIndex = 45;
            this.buttonSaveBin.Text = "Save to bin file";
            this.buttonSaveBin.UseVisualStyleBackColor = true;
            this.buttonSaveBin.Click += new System.EventHandler(this.buttonSaveBin_Click);
            // 
            // buttonLoadBin
            // 
            this.buttonLoadBin.Location = new System.Drawing.Point(958, 475);
            this.buttonLoadBin.Name = "buttonLoadBin";
            this.buttonLoadBin.Size = new System.Drawing.Size(126, 26);
            this.buttonLoadBin.TabIndex = 46;
            this.buttonLoadBin.Text = "Load Bin file";
            this.buttonLoadBin.UseVisualStyleBackColor = true;
            this.buttonLoadBin.Click += new System.EventHandler(this.buttonLoadBin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(886, 243);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(79, 44);
            this.buttonExit.TabIndex = 47;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(536, 242);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(92, 46);
            this.buttonReset.TabIndex = 48;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDisplayMountainBikes
            // 
            this.buttonDisplayMountainBikes.Location = new System.Drawing.Point(301, 241);
            this.buttonDisplayMountainBikes.Name = "buttonDisplayMountainBikes";
            this.buttonDisplayMountainBikes.Size = new System.Drawing.Size(200, 24);
            this.buttonDisplayMountainBikes.TabIndex = 49;
            this.buttonDisplayMountainBikes.Text = "Display MountainBikes";
            this.buttonDisplayMountainBikes.UseVisualStyleBackColor = true;
            this.buttonDisplayMountainBikes.Click += new System.EventHandler(this.buttonDisplayMountainBikes_Click);
            // 
            // buttonDisplayRoadBikes
            // 
            this.buttonDisplayRoadBikes.Location = new System.Drawing.Point(301, 264);
            this.buttonDisplayRoadBikes.Name = "buttonDisplayRoadBikes";
            this.buttonDisplayRoadBikes.Size = new System.Drawing.Size(200, 24);
            this.buttonDisplayRoadBikes.TabIndex = 50;
            this.buttonDisplayRoadBikes.Text = "Display RoadBikes";
            this.buttonDisplayRoadBikes.UseVisualStyleBackColor = true;
            this.buttonDisplayRoadBikes.Click += new System.EventHandler(this.buttonDisplayRoadBikes_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(702, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Type";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 543);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonDisplayRoadBikes);
            this.Controls.Add(this.buttonDisplayMountainBikes);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLoadBin);
            this.Controls.Add(this.buttonSaveBin);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.buttonSaveXml);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchSerial);
            this.Controls.Add(this.labelSearchSerial);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSeatHeight);
            this.Controls.Add(this.labelSeatHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.comboBoxSuspension);
            this.Controls.Add(this.labeSuspension);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMade);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxMade;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labeSuspension;
        private System.Windows.Forms.ComboBox comboBoxSuspension;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelSeatHeight;
        private System.Windows.Forms.TextBox textBoxSeatHeight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelSearchSerial;
        private System.Windows.Forms.TextBox textBoxSearchSerial;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonSaveBin;
        private System.Windows.Forms.Button buttonLoadBin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDisplayMountainBikes;
        private System.Windows.Forms.Button buttonDisplayRoadBikes;
        private System.Windows.Forms.Label label16;
    }
}