using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int x = 1; x < 16; x++)//公雞
            //{
            //    for (int y = 1; y < 32; y++)//母雞
            //    {
            //        for (int z = 1; z < 100; z++)//小雞
            //        {
            //            if (x + y + z == 100 && ((59 * x) + (29 * y)) == 900)
            //            {
            //                Console.WriteLine("公雞：" + x);
            //                Console.WriteLine("母雞：" + y);
            //                Console.WriteLine("小雞：" + z);
            //            }

            //        }
            //    }
            //}
            int x = 1;
            int y = (59 + x);
            int z = (29 + x);
            for (int i = 1; i <= 100; i++)
            {
                if (x + y + z == 100 && ((59 * x) + (29 * y)) == 900)
                {
                    Console.WriteLine("公雞：" + x);
                    Console.WriteLine("母雞：" + y);
                    Console.WriteLine("小雞：" + z);
                }
            }
            Console.ReadLine();
        }
    }
}
