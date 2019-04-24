using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int i;
            int sum = 0;

            for (i = 0; i < numbers.Length; i++)
            {
               
                if(numbers[i] % 2 == 0)
                { 
                    sum += numbers[i];
                }
               else if (numbers[i] % 2 !=0)
                {
                    sum += 0;
                }
            }

            return sum;

           
        }

        public bool IsSumOdd(List<int> numbers)
        {
          
            int total = numbers.Sum();
            return total % 2 != 0;


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
