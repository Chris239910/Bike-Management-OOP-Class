using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class RoadBike: Bike
    {
        private string seatHeight;
        public string SeatHeight { get => seatHeight; set => seatHeight = value; }
        public RoadBike(): base()
        {
            this.seatHeight = "000";
        }
        public RoadBike(int serialNumber, EnumMade made, EnumModel model, string speed, EnumColor color, int day, int month, int year, string seatHeight, string type): base(serialNumber, made, model, speed, color, day, month, year, type)
        {
            this.seatHeight = seatHeight;
        }
        public override string ToString()
        {
            string temp;
            temp = base.ToString() + "_ " + "\t_\t"+ this.seatHeight + "\t" + this.Type;
            return temp;
        }
    }
}
