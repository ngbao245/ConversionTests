using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversionTests
{
    public class Main
    {
        public class StringManipulator
        {
            public string ReverseString(string input)
            {
                char[] charArray = input.ToCharArray();
                int left = 0;
                int right = input.Length - 1;

                while (left < right)
                {
                    char temp = charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = temp;

                    left++;
                    right--;
                }

                return new string(charArray);
            }
        }
    }
}
