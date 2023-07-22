using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain2
{
    namespace MorseCodeEN
    {
        public static class MorseTranslator
        {
            private static Dictionary<char, string> _morseAlphabet = new Dictionary<char, string>()
            {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {' ', " "}
            };
            public static string TranslateToMorse(string text)
            {
                StringBuilder morseText = new StringBuilder();
                foreach (char symbol in text)
                {
                    morseText.Append(_morseAlphabet[symbol] + " ");
                }
                return morseText.ToString();
            }
            public static string TranslateFromMorse(string morseText)
            {
                StringBuilder text = new StringBuilder();
                string[] morseWords = morseText.Split(' ');
                foreach (string morseWord in morseWords)
                {
                    foreach (KeyValuePair<char, string> pair in _morseAlphabet)
                    {
                        if (pair.Value == morseWord)
                        {
                            text.Append(pair.Key);
                            break;
                        }
                    }
                    text.Append(" ");
                }
                text.Length--;
                return text.ToString();
            }
        }
    }

    namespace MorseCodeUA
    {
        public static class MorseTranslator
        {
            private static Dictionary<char, string> _morseAlphabet = new Dictionary<char, string>()
            {
                {'а', ".-"}, 
                {'б', "-..."}, 
                {'в', ".--"},
                {'г', "--."},
                {'д', "-.."},
                {'е', "."},
                {'є', "..-.."},
                {'ж', "...-"},
                {'з', "--.."},
                {'и', "-.--"},
                {'і', ".."},
                {'ї', ".---."},
                {'й', ".---"},
                {'к', "-.-"},
                {'л', ".-.."},
                {'м', "--"},
                {'н', "-."},
                {'о', "---"},
                {'п', ".--."},
                {'р', ".-."},
                {'с', "..."},
                {'т', "-"},
                {'у', "..-"},
                {'ф', "..-."},
                {'х', "...."},
                {'ц', "-.-."},
                {'ч', "---."},
                {'ш', "----"},
                {'щ', "--.-"},
                {'ь', "-..-"},
                {'ю', "..--"},
                {'я', ".-.-"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {' ', " "}
            };
            private static Dictionary<char, string> _morseUkrAlphabet = new Dictionary<char, string>()
            {
                {'и', ".."}, {'і', ".."}
            
            };
            public static string TranslateToMorse(string text)
            {
                StringBuilder morseText = new StringBuilder();
                foreach (char symbol in text)
                {
                    morseText.Append(_morseAlphabet[symbol] + " ");
                }
                return morseText.ToString();
            }
            public static string TranslateFromMorse(string morseText)
            {
                StringBuilder text = new StringBuilder();
                string[] morseWords = morseText.Split(' ');
                foreach (string morseWord in morseWords)
                {
                    foreach (KeyValuePair<char, string> pair in _morseAlphabet)
                    {
                        if (pair.Value == morseWord)
                        {
                            text.Append(pair.Key);
                            break;
                        }
                    }
                    text.Append(" ");
                }
                text.Length--;
                return text.ToString();
            }




        }


    }


}
