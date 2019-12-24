using System;
using System.Collections.Generic;
using System.Text;

namespace RAELOS
{
    static class Tests
    {
        public static void KeyboardFeedback1()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Kernal feedback test 1\n");
            Console.WriteLine("K Press:");
            Console.WriteLine("C Output:");
            while (true)
            {
                Console.SetCursorPosition(10, 6);
                string c = Console.ReadKey().KeyChar.ToString();
                Console.SetCursorPosition(10, 7);
                Console.Write(c + " ");
            }
        }
        public static void KeyboardTypeOut()
        {
            Console.Clear();
            while (true)
            {
                string c = Console.ReadKey(true).KeyChar.ToString();
                Console.Write(c);
            }
        }
        public static void NoDebug()
        {
            //Placeholder sub, this does nothing and proceeds to boot RAELOS
        }
    }
}
