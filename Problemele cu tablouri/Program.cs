using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemele_cu_tablouri
{

namespace Probleme_cu_tablouri
    {
        class Program
        {

            static void Main(string[] args)
            {

                // sumaElemVector();
                //primaPozitie();
                //minMax();
                deCateOriMaxMin();
            }
            /// <summary>
            /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
            /// </summary>
            private static void deCateOriMaxMin()
            {
                Random rnd = new Random();
                int n;
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int x = rnd.Next(11);
                v[0] = x;
                Console.Write($"{v[0]} ");
                int nr_aparitii1 = 1;
                int nr_aparitii2 = 1;
                int min = x;
                int max = x;

                for (int i = 1; i < n; i++)
                {
                    int y = rnd.Next(11);
                    Console.Write($"{y} ");
                    v[i] = y;
                    if (v[i] <= min)
                    {


                        if (v[i] == min)
                        {
                            nr_aparitii1++;
                            //Console.WriteLine("daaa");
                        }

                        else
                        {
                            nr_aparitii1 = 1;
                            min = v[i];
                        }

                    }
                    if (v[i] >= max)
                    {


                        if (v[i] == max)
                        {
                            nr_aparitii2++;
                            //Console.WriteLine("daa");
                        }

                        else
                        {
                            nr_aparitii2 = 1;
                            max = v[i];
                        }

                    }

                }
                Console.WriteLine();
                Console.WriteLine($"Minimul {min} apare de {nr_aparitii1} ori \n Maximul {max} apare de {nr_aparitii2} ori.");
                Console.ReadKey();
            }

            /// <summary>
            /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
            /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
            /// </summary>

            private static void minMax()
            {
                int n;
                Console.WriteLine("Introduceti n= ");
                n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int max;
                int min;
                for (int i = 0; i < n; i++)

                    v[i] = int.Parse(Console.ReadLine());

                min = v[0];
                max = v[0];
                for (int i = 1; i < n; i++)
                {
                    if (v[i] < min)

                        min = v[i];

                    else if (v[i] > max)

                        max = v[i];

                }
                Console.WriteLine($"Cel mai mare element al vectorului este{max}, iar cel mai mic element este {min} ");
                Console.ReadKey();


            }
            /// <summary>
            /// Se da un vector cu n elemente si o valoare k. 
            /// Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
            /// </summary>
            private static void primaPozitie()
            {
                Console.WriteLine("Introduceti n= ");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                Console.WriteLine("Introduceti k= ");
                int k = int.Parse(Console.ReadLine());
                int ok = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < n && ok == 0; i++)
                {
                    if (v[i] == k)
                    {
                        ok = 1;
                        Console.WriteLine(i);

                    }
                    else if (ok == 0) ;
                }

                Console.WriteLine("Rezultatul este -1");
                Console.ReadKey();

            }
            /// <summary>
            /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            /// </summary>
            private static void sumaElemVector()
            {
                int n;
                Console.WriteLine("Introduceti n= ");
                n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                    sum += v[i];
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
    }

}
  
