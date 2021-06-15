using System;
using static Morse_code.Morse_Translator.Morse;

namespace Morse_code
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Select Languages: 1) ToEnglish\n 2) ToMorse\n 3) ToMorseFromRussian\n 4) ToMorseFormRussian\n");
            var i = int.Parse(Console.ReadLine() ?? string.Empty);
            Translate(i);
        }
    }
}
