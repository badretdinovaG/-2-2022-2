using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace lab22222222
{
    class Program
    {
        static void Main(string[] args)
        {
                      
          Console.WriteLine("Введите n");
          int n = int.Parse(Console.ReadLine());
          int[] p = new int[n];
          int k = 0;
            int tmp = 0;
          for (int i = 0; i < n; i++)
          {
              Console.WriteLine("Введите {0}-й элемент", i);
              p[i] = int.Parse(Console.ReadLine());


          }
            int[] m = new int[n];
            Array.Copy(p, m, p.Length);


            

            for (int i = 0; i < n; i++)
            {
               

                if (i % 2 == 0 )
                {
                    p[i] = i * m[i];
                }
               else
               {
                    p[i] = -m[i];
               }
                


                if (p[i] < 0)
                {
                     while (k == 0)
                     {
                        p[i] = 0;
                        k++;
                     }
                  

                }
                if (p[i] % 3 == 0 && i != 3)
                   
                   tmp = m[3];
                {
                    p[i] = p[i] * tmp;
                }
                


                    Console.WriteLine("Выведите {0}-й элемент", i);
                Console.WriteLine(p[i]);
                
            }
            
            Console.ReadKey();

        }
    }

}
    

