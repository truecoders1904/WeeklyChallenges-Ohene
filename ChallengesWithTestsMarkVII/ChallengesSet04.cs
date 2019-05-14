using System;
<<<<<<< HEAD
using System.Linq;
using System.Collections.Generic;

=======
>>>>>>> d3a041469224332d51874851d2455dbe5b040243

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
<<<<<<< HEAD
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
<<<<<<< HEAD
            int num1 =str1.Length;
            int num2 =str2.Length;
            int num3 =str3.Length;
            int num4 =str4.Length;

            List<int> numbersList = new List<int>() { num1, num2, num3, num4 };

            return numbersList.Min();

=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
<<<<<<< HEAD
           
            List<int> numbersList = new List<int>() { number1, number2, number3, number4 };

            return (numbersList).Min();

       
=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
<<<<<<< HEAD
            biz.Name = "TrueCoders";


=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
<<<<<<< HEAD
            return ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1));

=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public bool IsStringANumber(string input)
        {
<<<<<<< HEAD
            if (String.IsNullOrEmpty(input))
                return false;
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '.' && c != '-')
                {
                    return false;
                }
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
          

        {
            int i, count = 0;
            for (i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                    count++;
            }
            if (2 * count > objs.Length)
                return true;
            return false;
         
=======
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public double AverageEvens(int[] numbers)
        {
<<<<<<< HEAD
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if (count == 0)

                return 0;
            return sum / count;


=======
            throw new NotImplementedException();
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
        }

        public int Factorial(int number)
        {
<<<<<<< HEAD
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {

                    factorial = factorial * i;
                }

                return factorial;
            }


        }


=======
            throw new NotImplementedException();
        }
>>>>>>> d3a041469224332d51874851d2455dbe5b040243
    }
}
