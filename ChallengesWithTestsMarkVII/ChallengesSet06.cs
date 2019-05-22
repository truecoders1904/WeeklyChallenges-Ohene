using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
