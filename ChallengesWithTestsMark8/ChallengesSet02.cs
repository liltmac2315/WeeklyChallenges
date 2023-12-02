  using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class 
        
        ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.Isletter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.length % 2 == 0) 
            {
            return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (vals.length % 2 == 0) 
            {
                return true;
            }
            else 
            { 
                return false
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (vals.length % 2 != 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count == 0) 
            { 
                return 0; 
            }
                return numbers.Min() + numbers.Max();
        
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
            if (numbers == null) 
            {
                return 0;
            }
            returns numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
