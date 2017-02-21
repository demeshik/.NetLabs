using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public static class MathObject
    {
            /// <summary>
            /// Возвращает объем пирамиды
            /// </summary>
            public static double GetVolume(this Pyramid A)
            {
                return 0.3 * A._Height * A._Square;
            }
            /// <summary>
            /// Возвращает площадь полной поверхности пирамиды.
            /// </summary>
            public static double AllSquare(Pyramid A)
            {
                double tempSquare = 0.5 * A._Height * A._Perimetr;
                return tempSquare + A._Square;
            }
            /// <summary>
            /// Возвращает радиус окружности, которую можно описать около пирамиды
            /// </summary>
            public static double Radius(Pyramid B)
            {
                return 3 * GetVolume(B) / AllSquare(B);
            }
            /// <summary>
            /// Увеличивает все размеры пирамиды B на величину x
            /// </summary>
            public static void Change(ref Pyramid B, double x)
            {
                B._Height += x;
                B._Perimetr += x;
                B._Square += x;
            }
    }
}
