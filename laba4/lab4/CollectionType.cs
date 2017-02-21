using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class CollectionType<T>
    {
        List<T> list = new List<T>();
        public CollectionType(){}
        public CollectionType(T x)
        {
            list.Add(x);
        }
        public CollectionType(T[]x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                list.Add(x[i]);
            }
        }
        public T this[int index]
        {

            set
            {
                if (index < 0 && index > list.Count)
                    throw new SystemException("Выход за пределы массива");
                var temp = list.ElementAt(index);
                list.Remove(temp);
                list.Insert(index, value);
                
            }
            get { return list.ElementAt(index); }
            
        }
        public void Add(T x)
        {
            list.Add(x);
        }
        public void Add(int index, T elem)
        {
            if (index < 0 && index > list.Count)
                throw new SystemException("Выход за пределы массива");
            T temp = list.ElementAt(index);
            list.Remove(temp);
            list.Insert(index, elem);
        }
        public void Remove(T x)
        {
            list.Remove(x);
        }
        public void Remove(int index)
        {
            if (index < 0 && index > list.Count)
                throw new SystemException("Выход за пределы массива");
            T temp = list.ElementAt(index);
            list.Remove(temp);
        }
        public void Show()
        {
            foreach (var x in list)
            {
                Console.Write("{0} ", x.ToString());
                Console.WriteLine();
            }
        }
        public void Sort()
        {
            list.Sort();
        }
        public void WriteToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("file.txt"))
            {
                foreach(var x in list)
                {
                    file.WriteLine(x);
                    file.WriteLine();
                }
            }
        }
    }
}
