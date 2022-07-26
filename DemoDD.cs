using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DelegateLambda
{

    public delegate void mydel(int x, int y);


    class DemoDD
    {
        static void Main(string[] args)
        {
            mydel d1 = delegate (int x, int y)
            {

                Console.WriteLine($"Sum = {x + y}");
            };

            d1(10, 20);

            //lambda Expression   =>

            mydel d2 = (x, y) => {

                Console.WriteLine($"Addition is {x + y}");
            };

            d2(20, 50);

        }

    }







        class DemoDD2
        {
            public delegate bool mydel4(int n);
            static void Main(string[] args)
            {

                mydel4 d4 = (n) =>
                {
                    bool isprime = true;
                    for (int i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    return isprime;

                };
                bool ans = d4(98);

                Console.WriteLine(ans);
            }
        }

        }

