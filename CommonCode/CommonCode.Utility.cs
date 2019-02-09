using System;

namespace SimpleThinker.CommonCode
{
    public static class Utility
    {
        public static void WriteWithColor(string text)
        {
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)(r.Next() % 15);
            Console.WriteLine(text + Environment.NewLine);
            Console.ResetColor();

        }


    }
}
