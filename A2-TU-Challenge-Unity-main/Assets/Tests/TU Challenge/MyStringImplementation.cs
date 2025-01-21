using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        internal static bool IsNullEmptyOrWhiteSpace(string input)  //verif chaine vide !!
        {
            if (input == null || input.Length == 0)  
            {
                return true;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')  
                {
                    return false;
                }
            }

            return true;
        }
        internal static string MixString(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                throw new ArgumentException("chaînes null !!");
            }

            if (a.Length != b.Length)
            {
                throw new ArgumentException("chaînes même longueur !!");
            }

            char[] result = new char[a.Length + b.Length];
            int index = 0;

            for (int i = 0; i < a.Length; i++)
            {
                result[index++] = a[i];
                result[index++] = b[i];
            }

            return new string(result);
        }
        internal static string ToLowerCase(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentException("chaîne null !!");
            }

            char[] result = new char[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];

                if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)(c + ('a' - 'A'));  // convert en minuscule
                }
                else
                {
                    result[i] = c; 
                }
            }

            return new string(result);
        }
        internal static string Voyelles(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentException("chaîne null !!");
            }

            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y',
                        'A', 'E', 'I', 'O', 'U', 'Y' };

            char[] result = new char[a.Length];
            int index = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < voyelles.Length; j++)
                {
                    if (a[i] == voyelles[j])
                    {
                        result[index++] = a[i];
                        break;
                    }
                }
            }

            return new string(result, 0, index);
        }
        public static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("chaîne null !!");
            }

            char[] reversed = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                reversed[i] = s[s.Length - 1 - i];
            }

            return new string(reversed);
        }
        internal static string BazardString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("chaîne null !!");
            }

            char[] firstPart = new char[input.Length / 2 + input.Length % 2]; // -> lettres prises en premier
            char[] secondPart = new char[input.Length / 2];  // -> lettres sautées
            int firstIndex = 0, secondIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    firstPart[firstIndex++] = input[i];  // +une lettre sur deux
                }
                else
                {
                    secondPart[secondIndex++] = input[i];  // +la lettre sauté
                }
            }

            // assemblage
            string result = "";
            for (int i = 0; i < firstPart.Length; i++)
            {
                result += firstPart[i];
            }
            for (int i = 0; i < secondPart.Length; i++)
            {
                result += secondPart[i];
            }

            return result;
        }
        internal static string UnBazardString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("chaîne null !!");
            }

            int mid = input.Length / 2 + input.Length % 2;  
            char[] original = new char[input.Length];
            int index = 0;

            // reconsitution chaîne en alternant parties
            for (int i = 0; i < mid; i++)
            {
                original[index++] = input[i];  // +la première partie 

                if (i + mid < input.Length)
                {
                    original[index++] = input[i + mid];  // +la deuxième partie 
                }
            }

            // chaîne de résultat
            string result = "";
            for (int i = 0; i < original.Length; i++)
            {
                result += original[i];
            }

            return result;
        }
        internal static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
