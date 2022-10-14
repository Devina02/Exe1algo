using Exe1algo;
using System;
using System.Runtime.Intrinsics.Arm;

namespace Exe1algo
{
    class program
    {
        private int[] devina = new int[112];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukan berapa banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 112)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 112 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i = 1) + " > ");
                string s1 = Console.ReadLine();
                devina[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" Elemen array yang telah tersusun ");
            Console.WriteLine("-----------------------------------------------");
            for (int DP = 0; DP < n; DP++)
            {
                Console.WriteLine(devina[DP]);
            }
            Console.WriteLine("");
        }
        public void exearray()
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int DP = 0; DP < n - i; DP++)
                {
                    if (devina[DP] > devina[DP + 1]) ;
                    {
                        int temp;
                        temp = devina[DP];
                        devina[DP] = devina[DP + 1];
                        devina[DP + 1] = temp;
                    }
               }
               
            }
        }
        static void Main(string[] args)
        {
            program myList = new program();
            myList.read();
            myList.exearray();
            myList.display();
            Console.WriteLine("\n\nTekan Enter untuk keluar");
            Console.Read();
        }
    }
    
}


