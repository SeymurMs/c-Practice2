using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(task1("anar")); 
            //Console.WriteLine(task2(1, 2, 3, 4, 5, 6));
            //Console.WriteLine(task3(31,4,6,8,9,10,11,21,31));
            //Console.WriteLine(cevreninSahesi(9));
            //Console.WriteLine(duzbucaqlininSahesi(5,4));
            //Console.WriteLine(uDCCs(4,1,2,3));



        }
        #region task1
        static dynamic task1(string word)
        {

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == 'a')
                {

                    count++;

                }

            }
            Console.WriteLine(count + "a var");
            return word;
        }
        #endregion

        #region task2
        static int task2(params int[] arr)
        {

            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;

        }
        #endregion

        #region task3
        static dynamic task3(int x ,params int[] arr)
        {
            
            
                int low = 0, 
                end = arr.Length - 1;
                while (low <= end)
                {
                    int m = low + (end - low) / 2;

                    
                    if (arr[m] == x)
                        return true;

                    
                    if (arr[m] < x)
                        low = m + 1;

                    
                    else
                        end = m - 1;
                }

                
                return false;
            #endregion

        #region task4
            static int cevreninSahesi(int r, int pi = 3)
            {
                Console.WriteLine("Cevrenin Sahesi");
                return pi * r * r;
            }
            static int duzbucaqlininSahesi(int a, int b)
            {
                Console.WriteLine("Duzbucaqlinin Sahesi");
                return a * b;
            }
            static int uDCCs(int r, int a, int b, int c)
            {
                Console.WriteLine("Ucbucaqlinin Daxiline Cekilmis Cevrenin Sahesi");
                int p = 0;
                p = (a + b + c) / 2;
                return p * r;
            }
            #endregion
        }

    }
}
