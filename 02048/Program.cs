﻿namespace _02048
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            var game = new Game();
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                game.UserInput(keyInfo.Key);
            }
        }
    }
}
