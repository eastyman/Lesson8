using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Liq
    {
        class Liq
        {
            private double volume;
            private string[] elements;

            public Liq(double v, string[] e)
            {
                volume = v;
                elements = e;
            }

            public static Liq operator +(Liq l1, Liq l2)
            {
                double volume = l1.volume + l2.volume;
                string[] elements = new string[l1.elements.Length + l2.elements.Length];

                for (int i = 0; i < l1.elements.Length; i++)
                {
                    elements[i] = l1.elements[i];
                }

                int j = 0;
                for (int i = l1.elements.Length; i < elements.Length; i++)
                {
                    elements[i] = l2.elements[j];
                    j++;
                }


                return new Liq(volume, elements);
            }

            public void Info()
            {
                Console.WriteLine("Volume: " + volume + "\n");

                foreach (string i in elements)
                {
                    Console.WriteLine(i);

                }
            }

        }
    }
}
