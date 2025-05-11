using System;

namespace ProjectConflict
{
    public class Calculator
    {
        public int Calculate(int a, int b)
        {
            // Branch1: menjumlahkan dan cetak hasil
            int result = a + b;
            Console.WriteLine($"Branch1: Hasil penjumlahan adalah {result}");
            return result;
        }
    }
}
