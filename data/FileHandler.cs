using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Xml;
using System.Xml.Serialization;
using MyBikes.bus;
namespace MyBikes.data
{
    public class FileHandler: IFileHandler
    {
        private static String binFilePath = @"../../data/bike.bin";
        //private static String txtLogin = @"../../data/textLogin.txt";
        private static String xmlFilePath = @"../../data/bike.xml";
        public void WriteToBinFile(List<Bike> myBikesList)
        {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();

            writer.Serialize(fs, myBikesList);

            fs.Close();
        }
        public List<Bike> ReadFromBinFile()
        {
            List<Bike> tempListOfBikes = new List<Bike>();

            if (File.Exists(binFilePath))
            {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binFormatter = new BinaryFormatter();

                //Deserialize is the reading
                tempListOfBikes = (List<Bike>)binFormatter.Deserialize(fs);

                fs.Close();
            }
            return tempListOfBikes;
        }
        public void WriteToXmlFile(List<Bike> myBikesList)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePath); //    
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bike>));
            serializer.Serialize(writer, myBikesList);
            writer.Close();

        }
        public List<Bike> ReadFromXmlFile()
        {

            List<Bike> tempListOfBikes = new List<Bike>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));
            StreamReader reader = new StreamReader(xmlFilePath);
            tempListOfBikes = (List<Bike>)xmlSerializer.Deserialize(reader);

            reader.Close();

            return tempListOfBikes;
        }
    }
}
