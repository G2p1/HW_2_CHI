using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW_2
{
    class StringNumberFinder
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

    class StringIndexFinder
    {
        public void indexMaxNumberInString(char[] inputString)
        {
            bool isStart = false;
            bool isStartIndexFind = true;
            int startIndex = 0;
            int maxDigit = 0;
            int maxIndex = 0;


            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    isStart = true;
                    if (isStartIndexFind)
                    {

                        startIndex = i + 1;

                        isStartIndexFind = false;
                    }
                }


                if (isStart)
                {
                    int digit;
                    int.TryParse(inputString[i].ToString(), out digit);
                    if (maxDigit < digit)
                    {
                        maxDigit = digit;
                        maxIndex = i;
                    }
                }
            }
            Console.WriteLine(maxIndex - startIndex);
        }
    }

    class Library
    {
        public void bookPages()
        {
            Random rnd = new Random();
            int[] pageInBook = new int[100];

            for(int i = 0; i < 100; i++)
            {
                pageInBook[i] = rnd.Next(1, 1000);
            }

            int maxPage = pageInBook[0];
            for(int i = 1; i<100; i++)
            {
                if(maxPage < pageInBook[i])
                {
                    maxPage = pageInBook[i];
                }
            }
            Console.WriteLine(maxPage);
        }

        
    }

    class CarSalon
    {
        public void CarSpeed()
        {
            Random rnd = new Random();
            double[] carSpeed = new double[40];

            for (int i = 0; i < 40; i++)
            {
                carSpeed[i] = rnd.Next(30, 320);
            }

            int maxCarSpeedIndex = 0, maxEndCarSpeedIndex = -1;
            double maxSpeed = carSpeed[0];

            for (int i = 1; i < 40; i++)
            {
                if (carSpeed[i] > maxSpeed)
                {
                    maxSpeed = carSpeed[i];
                    maxCarSpeedIndex = i;
                }

                if (carSpeed[i] == maxSpeed)
                {
                    maxEndCarSpeedIndex = i;
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringNumberFinder sNumberFinder = new StringNumberFinder();
            StringIndexFinder sIndexFinder = new StringIndexFinder();
            Library libraryBooks = new Library();
            CarSalon carSalon = new CarSalon();

            //Task1
            sNumberFinder.operationNumberInString(Console.ReadLine());
        
            //Task2
            sIndexFinder.indexMaxNumberInString(Console.ReadLine().ToCharArray());
            
            //Task3
            libraryBooks.bookPages();

            //Task4
            carSalon.CarSpeed();
        }
    }
}
