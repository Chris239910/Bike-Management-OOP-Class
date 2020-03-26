using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using MyBikes.bus;
using MyBikes.data;
using System.Runtime.Serialization;
using System.Collections;

namespace MyBikes.client
{
    public partial class MainForm : Form
    {
        List<Bike> myBikesList = new List<Bike>();
        int index;
        List<MountainBike> mountainBikesList = new List<MountainBike>();
        List<RoadBike> roadBikesList = new List<RoadBike>();
        static String binFilePath = @"../../data/bike.bin";
        //static String txtLogin= @"../../data/textLogin.txt";

        static String xmlFilePath = @"../../data/bike.xml";
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                Bike aBike = new Bike();
                MountainBike mBike = new MountainBike();
                mBike.Type = "MBike";
                mBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                mBike.Made = (EnumMade)comboBoxMade.SelectedIndex;
                mBike.Model = (EnumModel)comboBoxModel.SelectedIndex;
                mBike.Speed = textBoxSpeed.Text;
                mBike.Color = (EnumColor)comboBoxColor.SelectedIndex;
                mBike.Day = Convert.ToInt32(textBoxDay.Text);
                mBike.Month = Convert.ToInt32(textBoxMonth.Text);
                mBike.Year = Convert.ToInt32(textBoxYear.Text);
                mBike.Suspension = (EnumSuspension)comboBoxSuspension.SelectedIndex;
                mBike.Height = textBoxHeight.Text;
                aBike = (Bike)mBike;
                this.myBikesList.Add(mBike);
                this.mountainBikesList.Add(mBike);
            }else if(this.radioButton2.Checked == true)
            {
                Bike aBike = new Bike();
                RoadBike rBike = new RoadBike();
                rBike.Type = "RBike";
                rBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                rBike.Made = (EnumMade)comboBoxMade.SelectedIndex;
                rBike.Model = (EnumModel)comboBoxModel.SelectedIndex;
                rBike.Speed = textBoxSpeed.Text;
                rBike.Color = (EnumColor)comboBoxColor.SelectedIndex;
                rBike.Day = Convert.ToInt32(textBoxDay.Text);
                rBike.Month = Convert.ToInt32(textBoxMonth.Text);
                rBike.Year = Convert.ToInt32(textBoxYear.Text);

                rBike.SeatHeight = textBoxSeatHeight.Text;
                
                aBike = (Bike)rBike;
                //MessageBox.Show("Bike" + rBike);
                this.myBikesList.Add(rBike);
                this.roadBikesList.Add(rBike);
            }
        



        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (this.myBikesList.Capacity != 0)
            {
                foreach (Bike item in this.myBikesList)
                {
                    this.listBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("...NO DATA.....");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi.. We are updating the record : " + index);

            this.myBikesList[index].SerialNumber = Convert.ToInt32(textBoxSerialNumber.Text);


            this.myBikesList[index].Made = (EnumMade)comboBoxMade.SelectedIndex;
            this.myBikesList[index].Model = (EnumModel)comboBoxModel.SelectedIndex;
            this.myBikesList[index].Speed = textBoxSpeed.Text;
            this.myBikesList[index].Color = (EnumColor)comboBoxColor.SelectedIndex;
            this.myBikesList[index].Day = Convert.ToInt32(textBoxDay.Text);
            this.myBikesList[index].Month = Convert.ToInt32(textBoxMonth.Text);
            this.myBikesList[index].Year = Convert.ToInt32(textBoxYear.Text);
            //Need to add suspention, height, seatheigt
            MessageBox.Show("record updated...");
            this.listBox1.Items.Clear();
            foreach (Bike element in this.myBikesList)
            {
                this.listBox1.Items.Add(element);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.myBikesList.RemoveAt(index);
            this.listBox1.Items.Clear();
            foreach (Bike aBike in this.myBikesList)
            {
                this.listBox1.Items.Add(aBike);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (EnumMade element in Enum.GetValues(typeof(EnumMade)))
            {
                this.comboBoxMade.Items.Add(element);
            }
            this.comboBoxMade.Text = Convert.ToString(this.comboBoxMade.Items[0]);
            foreach (EnumModel element in Enum.GetValues(typeof(EnumModel)))
            {
                this.comboBoxModel.Items.Add(element);
            }
            this.comboBoxModel.Text = Convert.ToString(this.comboBoxModel.Items[0]);
            foreach (EnumColor element in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(element);
            }
            this.comboBoxColor.Text = Convert.ToString(this.comboBoxColor.Items[0]);
            foreach (EnumSuspension element in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(element);
            }
            this.comboBoxSuspension.Text = Convert.ToString(this.comboBoxSuspension.Items[0]);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSerialNumber.Text = "";
            comboBoxMade.Text = Convert.ToString(EnumMade.Undefined);
            comboBoxModel.Text = Convert.ToString(EnumModel.Undefined);
            textBoxSpeed.Text = "";
            comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            textBoxDay.Text = "";
            textBoxMonth.Text = "";
            textBoxYear.Text = "";
            listBox1.Items.Clear();
            textBoxSeatHeight.Text = "";
            comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
            textBoxHeight.Text = "";
            //need to add suspension, height, seatheight too


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Bike theBike = new Bike();

            foreach (Bike element in this.myBikesList)
            {
                if (element.SerialNumber == Convert.ToInt32(textBoxSearchSerial.Text))
                {
                    found = true;

                    theBike = element;

                }
            }
            if (found)
            {
                MessageBox.Show("Bike Found...:" + theBike);
            }
            else
            {
                MessageBox.Show("..Bike NOT Found...");
            }
        }

        private void buttonSaveBin_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();

            writer.Serialize(fs, myBikesList);

            fs.Close();
            //IFileHandler ifd;
            //ifd = new FileHandler();
            //ifd.WriteToBinFile(this.myBikesList);
        }

        private void buttonLoadBin_Click(object sender, EventArgs e)
        {
            if (File.Exists(binFilePath))
            {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();

                myBikesList = (List<Bike>)bin.Deserialize(fs);

                fs.Close();
            }
            //myBikesList.Clear();
            //this.listBox1.Items.Clear();
            //IFileHandler ifd;
            //ifd = new FileHandler();
            foreach (Bike item in myBikesList)
            {
                this.listBox1.Items.Add(item);
            }
           
        }

        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bike>));
            serializer.Serialize(writer, myBikesList);
            writer.Close();
            //IFileHandler ifd;
            //ifd = new FileHandler();
            //ifd.WriteToXmlFile(this.myBikesList);
        }

        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            myBikesList.Clear();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            StreamReader reader = new StreamReader(xmlFilePath);
            myBikesList = (List<Bike>)xmlSerializer.Deserialize(reader);

            reader.Close();
            //myBikesList.Clear();
            //this.listBox1.Items.Clear();
            //IFileHandler ifd;
            //ifd = new FileHandler();
            foreach (Bike item in myBikesList)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
            if (this.radioButton1.Checked == true)
            {
                textBoxSerialNumber.Text = "";
                comboBoxMade.Text = Convert.ToString(EnumMade.Undefined);
                comboBoxModel.Text = Convert.ToString(EnumModel.Undefined);
                textBoxSpeed.Text = "";
                comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
                textBoxDay.Text = "";
                textBoxMonth.Text = "";
                textBoxYear.Text = "";
                textBoxSeatHeight.Text = "";
                comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
                textBoxHeight.Text = "";
                this.comboBoxSuspension.Enabled = true;
                this.textBoxHeight.Enabled = true;
                this.textBoxSeatHeight.Enabled = false;

            }
            else
            {
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeight.Enabled = false;
                this.textBoxSeatHeight.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton2.Checked == true)
            {
                textBoxSerialNumber.Text = "";
                comboBoxMade.Text = Convert.ToString(EnumMade.Undefined);
                comboBoxModel.Text = Convert.ToString(EnumModel.Undefined);
                textBoxSpeed.Text = "";
                comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
                textBoxDay.Text = "";
                textBoxMonth.Text = "";
                textBoxYear.Text = "";
                textBoxSeatHeight.Text = "";
                comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
                textBoxHeight.Text = "";
                this.textBoxSeatHeight.Enabled = true;
            }
            else
            {
                this.textBoxSeatHeight.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            index = listBox1.SelectedIndex;
            MessageBox.Show("selected index: " + index);
            textBoxSerialNumber.Text = Convert.ToString(this.myBikesList[index].SerialNumber);

            comboBoxMade.Text = Convert.ToString(this.myBikesList[index].Made);
            comboBoxModel.Text = Convert.ToString(this.myBikesList[index].Model);
            textBoxSpeed.Text = this.myBikesList[index].Speed;
            textBoxDay.Text = Convert.ToString(this.myBikesList[index].Day);
            textBoxMonth.Text = Convert.ToString(this.myBikesList[index].Month);
            textBoxYear.Text = Convert.ToString(this.myBikesList[index].Year);
            comboBoxColor.Text = Convert.ToString(this.myBikesList[index].Color);
            if(this.myBikesList[index].Type == "MBike")
            {
                
                this.comboBoxSuspension.Enabled = true;
                this.textBoxHeight.Enabled = true;
                this.textBoxSeatHeight.Enabled = false;
                //radioButton1.Focus();

            }
            else if(this.myBikesList[index].Type == "RBike")
            {
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeight.Enabled = false;
                this.textBoxSeatHeight.Enabled = true;
                //radioButton2.Focus();

            }



            //?????????????????????????????????????????




            //comboBoxSuspension.Text = Convert.ToString(this.myBikesList[index].)

            //textBoxHeight.Text = this.myBikesList[index].Height;
        }

        private void buttonDisplayMountainBikes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (this.mountainBikesList.Capacity != 0)
            {
                foreach (MountainBike item in this.mountainBikesList)
                {
                    this.listBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("...NO DATA IN MOUNTAIN BIKES.....");
            }
        }

        private void buttonDisplayRoadBikes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (this.roadBikesList.Capacity != 0)
            {
                foreach (RoadBike item in this.roadBikesList)
                {
                    this.listBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("...NO DATA IN ROAD BIKES.....");
            }
        }

        private void textBoxSeatHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
            

    
}
