using System;
using laba_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string[] mas = { "Hello", "World", "!" };
                //CollectionType<string> collection = new CollectionType<string>(mas);
                //collection.Show();
                //collection[1] = "мир";
                //collection.Show();
                //Console.ReadKey();

                Pyramid pyramid1 = new Pyramid(2.3, 45.6, 34.5);
                Pyramid pyramid2 = new Pyramid(2.7, 85.1, 30.5);
                Pyramid pyramid3 = new Pyramid(2.1, 15.8, 36.5);
                Pyramid[] pyrmas = { pyramid1, pyramid2, pyramid3 };
                CollectionType<Pyramid> collPyr = new CollectionType<Pyramid>(pyrmas);
                collPyr.Show();
                collPyr.Sort();
                Console.WriteLine("После сортировки по id:");
                collPyr.Show();
                collPyr.WriteToFile();
                
                var pyrmasMax = pyrmas.Max(a => a.Id);
                var pyrmasMin = pyrmas.Min(a => a.Id);
                var selpyr = from v in pyrmas
                             where v._Height > 2.5
                             select v;

                Console.WriteLine(selpyr.Count());

                List<string> collectList = new List<string>();
                collectList.Add("Hello list");
                collectList.Add("Hi");

                var collectlistMax = collectList.Max(a => a.Length);
                var collectlistMin = collectList.Min(a => a.Length);
                

                Console.ReadKey();
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
