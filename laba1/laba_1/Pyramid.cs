using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class Pyramid : laba_1.IPyramid
    {
        protected static Random rnd;
        protected static int _Amount;
        public const string Manufacture = "Belaz Corp.";
        public readonly double Id;
        public double _Height { get; set; }
        public double _Perimetr { get; set; }
        public double _Square { get; set; }
        static Pyramid()
        {
            rnd = new Random();
            _Amount = 0;

        }
        public Pyramid()
        {
            _Amount++;
            this._Height = 0;
            this._Square = 0;
            this._Perimetr = 0;
            this.Id = rnd.Next(1, 100);
        }
        public Pyramid(double Apofem, double PerimetrBottom, double SquareBottom)
        {
            int random = rnd.Next(1, 100);
            _Amount++;
            this._Height = Apofem;
            this._Perimetr = PerimetrBottom;
            this._Square = SquareBottom;
            this.Id = (this._Square + this._Perimetr - this._Height) * random * 10;
        }
        /// <summary>
        /// Отображение сводной информации о классе
        /// </summary>
        public static void Information()
        {
            Console.WriteLine("Общее кол-во объектов класса: {0}", _Amount);
        }
        /// <summary>
        /// Отображение информации об объекте
        /// </summary>
        public void Info()
        {
            Console.WriteLine("Id - {0}, Apofem - {1}, PerimetrBottom - {2}, SquareBottom - {3}", this.Id, this._Height, this._Perimetr, this._Square);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Pyramid t = obj as Pyramid;
            if ((System.Object)t == null)
                return false;
            return (_Height == t._Height) && (_Square == t._Square) && (_Perimetr == t._Perimetr);
        }
        public override int GetHashCode()
        {
            return (int)_Height ^ (int)_Square;
        }
        public bool Equals(Pyramid temp)
        {
            if ((object)temp == null)
                return false;
            return (_Height == temp._Height) && (_Square == temp._Square);
        }
    }
}
