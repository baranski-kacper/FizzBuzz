using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Podal Liczbe");
                var CheckValue = new FizzBuzz();
                var value = Liczba();               
                Console.WriteLine(CheckValue.Check(value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

           
        }

        private static int Liczba()
        {
            if (!int.TryParse(Console.ReadLine(), out int value)) throw new Exception("Podana Wartosć jest nie prawidłowa!");
            return value;
        }
    }
}
