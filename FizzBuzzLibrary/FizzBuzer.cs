using System;
using FizzBuzzLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzer
    {
        public static string GetValue(int input)
        {
            string output = string.Empty;
            if (input%3==0)
            {
                output += "Fizz";
            }
            else if (input%5==0)
            {
                output += "Buzz";
            }
            else if (string.IsNullOrEmpty(output))
            {
                 
                output = input.ToString();
                
            }
            return output;
        }
    }
}
