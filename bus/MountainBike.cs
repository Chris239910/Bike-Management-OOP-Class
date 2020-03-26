using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class MountainBike : Bike
    {

        private EnumSuspension suspension;
        private string height;
        public EnumSuspension Suspension { get => suspension; set => suspension = value; }
        public string Height { get => height; set => height = value; }
        public MountainBike() : base()
        {
            this.suspension = EnumSuspension.Undefined;
            this.height = "000";
        }
        public MountainBike(int serialNumber, EnumMade made, EnumModel model, string speed, EnumSuspension suspension, string height, EnumColor color, int day, int month, int year, string type) : base(serialNumber, made, model, speed, color, day, month, year, type)
        {
            this.suspension = suspension;
            this.height = height;
        }
        public override string ToString()
        {
            string temp;
            temp = base.ToString() + this.suspension + "\t" + this.height+"\t_"+"\t"+this.Type;
            return temp;
        }
    }
}
