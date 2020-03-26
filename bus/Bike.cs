using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace MyBikes.bus
{[Serializable]
  [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    
    public class Bike
    {
        private int serialNumber;
        private EnumMade made;
        private EnumModel model;
        private string speed;
        private EnumColor color;
        //private Date madeDate;
        private int day;
        private int month;
        private int year;
        private string type;


        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        public EnumMade Made { get => made; set => made = value; }
        public EnumModel Model { get => model; set => model = value; }
        public string Speed { get => speed; set => speed = value; }
        public EnumColor Color { get => color; set => color = value; }
        //public Date MadeDate { get => madeDate; set => madeDate = value; }
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public string Type { get => type; set => type = value; }

        public Bike()
        {
            this.serialNumber = 0000;
            this.made = EnumMade.Undefined;
            this.model = EnumModel.Undefined;
            this.speed = "000";
            this.color = EnumColor.Undefined;
            this.day = 00;
            this.month = 00;
            this.year = 00;
            this.type = "Undefined";


        }
        public Bike(int serialNumber, EnumMade made, EnumModel model, string speed, EnumColor color, /*Date madeDate*/int day, int month, int year, string type)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.color = color;
            this.day = day;
            this.month = month;
            this.year = year;
            this.type = type;



        }
        public override string ToString()
        {
            String state;
            state = this.SerialNumber+"\t"+this.Made+"\t"+this.Model+"\t"+this.Speed+"\t"+this.Color+"\t"+this.day+"/"+this.month+"/"+this.year+"\t";
            return state;

        }
    }

}
