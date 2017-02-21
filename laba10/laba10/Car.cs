using System.Drawing;
using System.Collections.Generic;
namespace laba10
{
    static class Car
    {
        public static List<string> modifNames = new List<string>();
        public static List<object> modifValues = new List<object>();
        public static string Name { get; set; }
        public static string Color { get; set; }
        public static string Year { get; set; }
        public static string Value { get; set; }
        public static string Number { get; set; }
        public static Image Image { get; set; }
        public static void Clear()
        {
            Name = string.Empty;
            Color = string.Empty;
            Year = string.Empty;
            Value = string.Empty;
            Number = string.Empty;
            Image = null;
        }
    }
}
