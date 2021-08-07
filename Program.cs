using System;
using System.Collections.Generic;

namespace CountPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Result.sockMerchant(1,new List<int> { 10, 20, 20, 10, 10,30,50,10,20}));
            //
            Console.WriteLine(Result.sockMerchant(1, new List<int> { 1, 1, 3, 1, 2, 1 ,3, 3, 3, 3 }));
            Console.WriteLine("Hello World!");
        }
    }

    class Result
    {


        public static int sockMerchant(int n, List<int> ar)
        {
            // sort list
            ar.Sort();
            int countarValuesSame = 0;
            int pairReturn = 0;
            int arPrevious = -1;
            int count = 1;
            foreach (int arValue in ar)
            {
                //first pass
                if (arPrevious == -1)
                {
                    arPrevious = arValue;
                }
                else // all other passes
                {
                    if (arPrevious == arValue)
                    {
                        count = count + 1;  // number pairs
                    }
                    else
                    {  // values not same restart count

                        if (count > 1)
                        {
                            pairReturn = pairReturn + count / 2;
                            count = 1;
                        }
                        arPrevious = arValue;
                    }
                }
            }

            return pairReturn + count/2;

        }

    }


}
