using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(5, 6, '*');
            Draw(5, 7, '*');
            Draw(5, 8, '*');

            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
