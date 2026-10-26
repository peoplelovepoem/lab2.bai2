using System;
using System.Collections.Generic;

namespace CSLab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n <= 0)
            {
                Console.Write("Nhap so luong phan tu n (n > 0): ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Loi: Vui long nhap mot so nguyen lon hon 0!");
                }
            }

            List<int> ml = new List<int>();

            Random rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < n; i++)
            {
                ml.Add(rnd.Next(100));
            }

            Console.WriteLine("\nDay so ngau nhien vua phat sinh:");
            foreach (int item in ml)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ml.Sort();

            Console.WriteLine("\nDay so sau khi sap xep tang dan:");
            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}