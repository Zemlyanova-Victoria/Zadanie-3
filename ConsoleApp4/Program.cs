using System;
using static System.Console;
using static System.Convert;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1 - Zadanie1; \n2 - Zadanie2; \n3 - Zadanie3");
            int y = ToInt32(ReadLine());
            if (y == 1)
            {
                int[] n = new int[5] { 6, -8, -9, 4, 0 };
                int minimal = n[0];
                int nomer = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    if (Math.Abs(n[i]) < minimal)
                    {
                        minimal = Math.Abs(n[i]);
                        nomer = i;
                    }
                }
                WriteLine($"Minimalnoe:{ minimal} and index:{nomer}");
            }
            else if (y == 2) 
            {
                int[] m = new int[10] { 7, -4, 9, 59, 59, 22, 0, 9, -8, 4 };
                string z = "";
                int count = 0;

                for (int i = 0; i < m.Length; i++)
                {
                    for (int j = 0; j < m.Length; j++)
                    {
                        if (m[i] == m[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1) z = z + m[i] + "; ";
                    count = 0;
                }
                WriteLine("Ynikalne element massiva: " + z);
            }
            else if (y == 3)
            {
                int[] k = new int[10];
                Random r = new Random();
                WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    k[i] = r.Next(-10, 10);
                    Write(k[i] + " ");
                }
                Write("\nPologitelnie element massiva: ");
                for (int i = 0; i < 10; i++)
                {
                    if (k[i] < 0)
                    {
                        k[i] = 0;
                    }
                    else Write(k[i] + " ");
                }
            }
        }
    }
}
