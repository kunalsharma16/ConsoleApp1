using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
    // kunal sharma
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        private static object orange;

        static void Main(string[] args)
        {
            

            Program2 orange = new Program2();
            Console.WriteLine(orange.Gematria("universe"));

        }

        

        public int Gematria(string word)
        {
            int GematraicValue = 0;
            for (int i =0;i<word.Length;i++)
            { GematraicValue += LetterValue(word[i].ToString());}
            return GematraicValue;
        }

        public int LetterValue (string letter) { 
            int x= 0;
            while (Letters[x] != letter)
            {
                if (Letters[x++] == letter) return x;

            }
            return x;

    }
}
    }
