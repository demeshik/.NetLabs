using System.IO;
using System.Xml.Serialization;

namespace laba6
{
    static class Serializer
    {
        public static void Serialize<T>(T temp)
        {
            XmlSerializer forma = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream("pers.xml", FileMode.Create, FileAccess.Write);
            using (stream)
            {
                forma.Serialize(stream, temp);
            }
            stream.Close();
        }
    }
}
