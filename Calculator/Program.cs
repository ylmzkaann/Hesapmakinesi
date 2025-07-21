using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Birinci sayıyı gir: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı gir: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Toplama:   {calc.Add(x, y)}");
            Console.WriteLine($"Çıkarma:   {calc.Subtract(x, y)}");
            Console.WriteLine($"Çarpma:    {calc.Multiply(x, y)}");
            try
            {
                Console.WriteLine($"Bölme:     {calc.Divide(x, y)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }

    public class Calculator
    {
        internal object Add(double x, double y)
        {
            throw new NotImplementedException();
        }

        internal object Divide(double x, double y)
        {
            throw new NotImplementedException();
        }

        internal object Multiply(double x, double y)
        {
            throw new NotImplementedException();
        }

        internal object Subtract(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
