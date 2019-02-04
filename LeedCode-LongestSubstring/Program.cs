using System;
using System.Collections.Generic;

namespace LeedCode_LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int LengthOfLongestSubstring(string s)
        {
            string buffer = "";
            string longeststring = "";
            foreach (char c in s)
            {

                if (!buffer.Contains(c))
                    buffer += c;
                else
                {
                    if (buffer.Length > longeststring.Length)
                    {
                        longeststring = buffer;
                    }
                    int indexof = buffer.IndexOf(c);
                    buffer = buffer.Substring(indexof + 1) + c;
                }
            }
            if (buffer.Length > longeststring.Length)
            {
                longeststring = buffer;
            }

            return longeststring.Length;
        }

        public int LengthOfLongestSubstring_slow(string s)
        {
            Dictionary<int, string> maptable = new Dictionary<int, string>();
            int positioncounter = 1;
            int eligiblecounterstartingposition = 1;
            int longeststringpointer = 1;
            int longeststringpointerlength = 0;
            int overallloop = 0;
            foreach (char c in s)
            {
                if (!maptable.ContainsKey(positioncounter))
                    maptable.Add(positioncounter, c.ToString());
                for (int j = eligiblecounterstartingposition; j < positioncounter; j++)
                {
                    if (!maptable[j].Contains(c))
                    {
                        maptable[j] += c.ToString();
                        if (maptable[j].Length > longeststringpointerlength)
                        {
                            longeststringpointer = j;
                            longeststringpointerlength = maptable[j].Length;
                        }
                    }
                    else
                    {
                        eligiblecounterstartingposition++;
                    }
                    overallloop++;
                }
                positioncounter++;
            }
            if (longeststringpointerlength == 0 && maptable.Count > 0)
            {
                longeststringpointerlength = 1;
            }
            return longeststringpointerlength;
        }
    }
}
