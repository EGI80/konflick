using System;

namespace ProjectConflict
{
    public class Calculator
    {
        public (int sum, int product) Calculate(int a, int b)
        {
            int sum = a + b;
            int product = a * b;
            Console.WriteLine($"Hasil penjumlahan: {sum}");
            Console.WriteLine($"Hasil perkalian: {product}");
            return (sum, product);
        }
    }
}
