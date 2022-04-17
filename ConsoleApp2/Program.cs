using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var alphabet = new Dictionary<int, string>()
            //{
            //    { 1, "A" },{2,"B"},{3, "C" },{4,"D"},{5,"E"},{6, "F"}, {7 , "G" },{8 ,"H" },
            //    {9, "I" },{ 10 ,"J" },{11 ,"K" },{12 ,"L" },{13 ,"M" },{14 ,"N" }, {15 ,"O" },
            //    {16 ,"P" }, {17 ,"Q" }, {18 ,"R" }, {19 ,"S" }, {20 ,"T" }, {21 ,"U" }, { 22,"V" },
            //    {23 ,"W" }, {24 ,"X" }, {25 ,"Y" }, {26 , "Z" }
            //};       
        }
        public static string AlphabetPosition(string text)
        {
            text = text.ToUpper();
            string result = "";
            var alphabet = new int[]
            {
                ' ','A','B','C','D','E','F','G','H',
                'I','J','K','L','M','N','O',
                'P','Q','R','S','T','U','V',
                'W','X','Y','Z'
            };
            for (int i = 0; i < text.Length; i++)
            {

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == ' ')
                        continue;

                    if (text[i] == alphabet[j])
                    {
                        result += $"{j} ";
                    }
                }

            }
            var output = result.Remove(result.Length - 1);
            return output;
        }
    }
    

}
