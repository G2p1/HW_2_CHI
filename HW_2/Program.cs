using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class StringManipulator
    {
        public void operationNumberInString(string inputString)
        {
            string[] tokens = inputString.Split(' ', ',', ';');
            int sum = 0;
            int maxInString;
            int.TryParse(string.Join("", tokens[0].Where(c => char.IsDigit(c))), out maxInString);
            sum += maxInString;

            for (int token = 1; token < tokens.Length;token++)
            {
                int number;
                int.TryParse(string.Join("", tokens[token].Where(c => char.IsDigit(c))), out number);
                
                if (number > maxInString)
                {
                    maxInString = number;
                }
                
                sum += number;
            }
            Console.WriteLine(sum);
            Console.WriteLine(maxInString);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulator sManipulator = new StringManipulator();

            sManipulator.operationNumberInString(Console.ReadLine());
        }
    }
}
