using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 9;
            short y = 14;
            int z = 2;
            long t = 4;
            float k = 21;

            /* z = y; hata alırız çünkü küçük olan büyük olana atanır. İmplicit Casting  */
            y = x;
            z = y;
            k = x;

            string f;

            /* f = x; Hata alırız çünkü değişken tipleri farklıdır Explicit Casting olarak yapmamız gerek */

            double a = 13;
            int b;
            b = Convert.ToInt32(x); // yada y = (int)x olarakda yazabiliiz.
            string h = a.ToString();


            //Değişkenler en son aldığı değeri tutar.
 

        }
    }
}
