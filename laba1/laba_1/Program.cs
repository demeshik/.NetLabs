using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Pyramid pyr = new Pyramid();
            Pyramid pyr1 = new Pyramid(1.5, 4, 5);
            Pyramid pyr2 = new Pyramid(4, 5, 4);

            List<Pyramid> pyramids = new List<Pyramid>();
            pyramids.Add(pyr);
            pyramids.Add(pyr1);
            pyramids.Add(pyr2);

            var pyrQuery =
                from py in pyramids
                select new { py.Id };
            foreach (var v in pyrQuery)
            {
                Console.WriteLine(v.Id);
            }
            pyr.GetVolume();
        }
    }
}
