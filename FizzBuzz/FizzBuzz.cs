using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string Check(int valueCheck)
        {
            var value = "";
            if (valueCheck % 3 == 0) value = "Fizz";
            else value = valueCheck.ToString();
            if (valueCheck % 5 == 0) value = "Buzz";
            if (valueCheck % 3 == 0 && valueCheck % 5 == 0) value = "FizzBuzz";
            return value;
        }

    }
}
