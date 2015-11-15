using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //int res = Arifm.Sum(1,10);
            //Console.WriteLine(res);
            //res = Arifm.Mul(10, 15);
            //Console.WriteLine(res);

            //3

            //string[] waterElem = new string[2] { "H2", "O" };
            //Liq water = new Liq(0.6, waterElem);
            //water.Info();

            //string[] spirtElem = new string[3] { "C2", "H5", "O" };
            //Liq spirt = new Liq(0.4, spirtElem);
            //spirt.Info();

            //Liq vodka = water + spirt;
            //vodka.Info();
            //Console.WriteLine("\n" + "Делим водку на троих и выводим" + "\n");
            //Liq[] partialVodka = vodka / 3;
            //for (int i = 0; i < partialVodka.Length; i++)
            //{
            //    partialVodka[i].Info();
            //}
            
            ////4
            //Common<Liq> test = new Common<Liq>(vodka);
            //test.Info();
            //5
            PersonInfo("Васян", 1);
        }

        static void PersonInfo(string name, int? childCount)
        {                     
            if (childCount == null)
            {
                Console.WriteLine(name + ", Кол во детей неизвестно");
            }
            else if (childCount>0)
            {
                Console.WriteLine(name + " детей "+childCount);
            }
            else
            {
                Console.WriteLine(name + ", нет детей");
            }
        } 
    }
}
