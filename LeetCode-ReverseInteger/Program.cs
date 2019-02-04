using System;

namespace LeetCode_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(Reverse(-214748386));
            Console.Read();
        }

        static int Reverse(int x)
        {
            int sign = 1;
            //System.Collections.Stack stck = new System.Collections.Stack();
            string reversenumber = "";
            int finalnumber = 0;
            //int counter = 1;
            if (x == -2147483648)
            {
                x = x + 1;
            }
            if (x < 0)
            {
                sign = -1 * sign;
                x = x * -1;
            }
            char[] c = x.ToString().ToCharArray();
            Array.Reverse(c);
            reversenumber = new string(c);
            //foreach (char i in c)
            //{
            //    reversenumber += c[c.Length - counter];
            //    counter++;
            //}

            //while (stck.Count > 0)
            //{

            //    reversenumber += stck.Pop();

            //}
            try
            {
                finalnumber = Convert.ToInt32(reversenumber);
            }
            catch (System.OverflowException)
            {
                finalnumber = 0;
            }
            return finalnumber * sign;

        }
    }
}
