using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

// MISSSING CharacterIsNotALetter

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int i;
            int sum = 0;

            if (!(numbers?.Length > 0))
            {
                return 0;
            }

            else
            for (i = 0; i < numbers.Length; i++)
            { 

                { 
                    sum += numbers[i];
                }
              
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            //MISSING nullable type
            int i;
            int sum = 0;

            if (numbers.Length == 0 || numbers == null)
            {
                return 0;
            } 

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
          //MISSING NULL
            int total = numbers.Sum();
            return total % 2 != 0;


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
            if (number < 0 || number == 0)
            {
                return 0;
            }

            else if (number % 2 == 0)
            {
                return number / 2;
            }
            else 
            {
                return (number - 1) / 2;
            }
        }
    }
}
