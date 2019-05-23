using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {   
            if (words == null)//cannot check the case of a null, what if the collection is null
            {
                return false;
            }
            string wordToFind = word;
            if (ignoreCase == false)
            {
                foreach (string item in words)
                {
                    if (item == wordToFind)
                    {
                        return true;
                    }
                        
                }
            }
            else
                foreach (string item in words)
                {
                    if(item == null)
                    {
                        break;
                    }
                    else if (item.ToLower() == wordToFind)
                    {
                        return true;
                    }      
                }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 0) return false;
            if (num == 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 0)
                return -1;
            if (str.Length == 1)
                return 0;


            for (int i = str.Length - 1; i >= 0; i--)
            {
                int counter = 0;
                for (int j = 0; j < str.Length; j++)
                {
                   
                    if (str[j] == str[i])
                    {
                        counter++;
                    }
                    if (counter > 1)
                    {
                        break;
                    }
                }
                if (counter == 1)
                    return i;
            }
            return -1;
        } 

        public int MaxConsecutiveCount(int[] numbers)
        {
            {
                int newCount = 0;
                int counter = 0;
                for (int i = 0; i < numbers.Length; i++)
                {   
                    newCount = 1;//change from zero to 1

                    for (int j = i + 1; j < numbers.Length; j++)//change to j = i
                    {
                        if (numbers[i] == numbers[j])
                        {
                            newCount++;//you should do something to this loop if the condition is not met
                        }
                        else
                        {
                            break;//when the first condition is not met, break
                        }

                    }
                    if (newCount > counter)//put this loop OUTSIDE first for loop
                    {
                        counter = newCount;//change by adding 1 while above is
                    }

                }
                return counter;
            }
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            List<double> listOfNth = new List<double>();
            double[] emptyArray = new double[0];
            if (elements == null)//because the list can be null!
            { return emptyArray; }
            if (elements.Count <= 0 || (n <= 0) )//if 
            {
                return emptyArray;
            }
            for(int i = n - 1; i < elements.Count; i+= n)
            {

                listOfNth.Add(elements[i]);

            }

            return listOfNth.ToArray();        
        }
    }
}
