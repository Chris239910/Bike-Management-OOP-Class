using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBikes.bus;


namespace MyBikes.data
{
    public interface IFileHandler
    {
        List<Bike> ReadFromBinFile();
        void WriteToBinFile(List<Bike> myBikesList);

        List<Bike> ReadFromXmlFile();
        void WriteToXmlFile(List<Bike> myBikesList);
    }
}
