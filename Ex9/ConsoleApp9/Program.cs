using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] A = new int[] {3,5,7,1,8,8,9,9 };//deklaraciq i inicializaciq na masiv
           // int[] C = { -2,5,7,-9,0,1,3,5 };//deklaraciq i inicializaciq na masiv
           // int[] B=new int [3];
           // B[0] = 2;
           // B[1] = 17;
           // B[2] = -44;
           // // B[3] = 18;
           // int n = int.Parse(Console.ReadLine());
           // int[] D = new int[n];
           // for (int i = 0; i < n; i++)
           // {
           //     D[i] = int.Parse(Console.ReadLine());
           //    // D[i] = i*3;
           // }
           // Console.WriteLine("===========otpechatvane C===================");
           // for (int i = 0; i < 8; i++)
           // {
           //     Console.Write(C[i] +" ");
           // }
           // Console.WriteLine();
           // Console.WriteLine("===========otpechatvane A===================");
           // for (int i = 0; i < 8; i++)
           // {
           //     Console.Write(A[i] + " ");
           // }
           // Console.WriteLine("namirane na nai - golqmata chislo v C");
           //// Console.WriteLine(int.MinValue);
           // int max = C[0];
           // for (int i = 0; i < 8; i++)
           // {
           //     if (C[i] > max) max = C[i];
           // }
           // Console.WriteLine("nai-golqmata"+max);
           // double sum = 0;
           // for (int i = 0; i < 8; i++)
           // {
           //     if(C[i]%2==0)sum = sum + C[i];
           // }

            int[,] E = new int[2, 3];
            E[0, 1] = 4;
            E[1, 0] = 3;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    E[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("===================opt=============");

            for (int i = 0; i < E.; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write( E[i, j] +" ");

                }
                Console.WriteLine();
            }

            int max = E[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (E[i, j] > max) max = E[i, j];

                }
                
            }
            Console.WriteLine("max dvumeren "+max);

        }
    }
}
