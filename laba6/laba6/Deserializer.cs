using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace laba6
{
    static class Deserializer
    {
        public static List<Person> Deserialize()
        {
            List<Person> List = new List<Person>();
            XmlReader reader;
            Person pers = null;
            FileStream stream = File.Open("pers.xml", FileMode.Open);
            if (stream == null)
                return null;
            reader = XmlReader.Create(stream);
            try
            {
                using (reader)
                {
                    while (reader.Read())
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (reader.Name == "Person")
                                {
                                    pers = new Person(reader.ReadOuterXml());
                                    List.Add(pers);
                                }
                                break;
                        }
                }
            }
            catch(XmlException e)
            {
                MessageBox.Show("Произошла ошибка загрузки файла. Возможно, файл пуст.\nДополнительная информация: " + e.Message);
            }
            stream.Close();
            return List;
        }
    }
}
