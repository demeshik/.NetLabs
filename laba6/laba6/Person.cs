using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace laba6
{
    [Serializable]
    public class Person
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Date")]
        public string Date { get; set; }
        [XmlElement("Color")]
        public string Color { get; set; }
        [XmlElement("Font")]
        public string Font { get; set; }
        [XmlElement("About")]
        public string About { get; set; }
        [XmlElement("Browser")]
        public string Browser { get; set; }

        public Person() { }
        public Person(string path)
        {
            LoadData(path);
        }
        public void LoadData(string source)
        {
            XmlSerializer mySerializer = new XmlSerializer(GetType());
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(source)))
            {
                object obj = mySerializer.Deserialize(ms);
                IEnumerable<PropertyInfo> infos = obj.GetType().GetRuntimeProperties();
                foreach (PropertyInfo info in infos)
                {
                    PropertyInfo p2 = this.GetType().GetRuntimeProperty(info.Name);
                    if (p2 != null && p2.CanWrite)
                        p2.SetValue(this, info.GetValue(obj, null), null);
                }
            }
        }
        public override string ToString()
        {
            return $"Имя - {this.Name}. Дата рождения - {this.Date}. Цвет - {this.Color}. О себе: {this.About}. Браузер - {this.Browser}";
        }
    }
}
