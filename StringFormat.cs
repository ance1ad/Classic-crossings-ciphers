using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public static class StringFormat
    {
        // удаляем из строки original символы не входящие в алфавит
        public static string DeleteSymbols(string original, string alphabet)
        {
            string tempstr = "";
            for (int i = 0; i < original.Length; i++)
            {
                if (InString(alphabet, original[i].ToString()))
                {
                    tempstr += original[i];
                }
            }
            return tempstr;
        }

        // проверка на наличие символа в строке
        public static bool InString(string alphabet, string not)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i].ToString() == not) return true;
            }
            return false;
        }
        // удаление повторяющихся символов
        public static string DeleteRepeatSymbols(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!InString(newStr, str[i].ToString())) newStr += str[i];
            }
            return newStr;
        }
    }

    
}
