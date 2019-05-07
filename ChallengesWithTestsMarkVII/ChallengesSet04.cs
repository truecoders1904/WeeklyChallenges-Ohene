using System;
using System.Linq;
using System.Collections.Generic;


namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
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
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int num1 =str1.Length;
            int num2 =str2.Length;
            int num3 =str3.Length;
            int num4 =str4.Length;

            List<int> numbersList = new List<int>() { num1, num2, num3, num4 };

            return numbersList.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           
            List<int> numbersList = new List<int>() { number1, number2, number3, number4 };

            return (numbersList).Min();

       
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1));

        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
          

        {
            int i, count = 0;
            for (i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                    count++;
            }
            if (count > objs.Length / 2)
                return true;
            else if (count * 2 < objs.Length)
                return false;
            return false;
         
        }

        public double AverageEvens(int[] numbers)
        {
            //int sumOfNumbers = 0;
            //convert sumOfNumbers to a bool 
            //double count = 0;
            //count cannot be 0;
            throw new NotImplementedException();

        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
