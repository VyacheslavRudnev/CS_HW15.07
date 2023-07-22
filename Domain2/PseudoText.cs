using System.Text;

namespace Domain2
{
    namespace PseudoTextUA
    {
        public class Text
        {
            private int vowelsCount;
            private int consonantsCount;
            private int maxLength;
            public int VowelsCount
            {
                get { return vowelsCount; }
                set { vowelsCount = value; }
            }
            public int ConsonantsCount
            {
                get { return consonantsCount; }
                set { consonantsCount = value; }
            }
            public int MaxLength
            {
                get { return maxLength; }
                set { maxLength = value; }
            }
            public Text() { }
            public Text(int vowelsCount, int consonantsCount, int maxLength)
            {
                this.vowelsCount = vowelsCount;
                this.consonantsCount = consonantsCount;
                this.maxLength = maxLength;
            }
            private static char GetRandomChar(char[] chars)
            {
                Random random = new Random();
                int index = random.Next(chars.Length);
                return chars[index];
            }
            public static string GeneratePseudoWord(int vowelsCount, int consonantsCount, int maxLength)
            {
                char[] vowels = { 'а', 'о', 'у', 'е', 'и', 'і', 'ї', 'ю', 'я' };
                char[] consonants = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й',
                                      'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т',
                                      'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

                Random random = new Random();
                int length = random.Next(1, maxLength + 1);

                StringBuilder pseudoWordBuilder = new StringBuilder();

                for (int i = 0; i < length; i++)
                {
                    if ((vowelsCount > 0 && consonantsCount > 0) || pseudoWordBuilder.Length == 0)
                    {
                        char randomChar = random.Next(2) == 0 ? GetRandomChar(vowels) : GetRandomChar(consonants);
                        pseudoWordBuilder.Append(randomChar);

                        if (Array.IndexOf(vowels, randomChar) >= 0)
                            vowelsCount--;
                        else
                            consonantsCount--;
                    }
                    else if (vowelsCount > 0)
                    {
                        char randomChar = GetRandomChar(vowels);
                        pseudoWordBuilder.Append(randomChar);
                        vowelsCount--;
                    }
                    else
                    {
                        char randomChar = GetRandomChar(consonants);
                        pseudoWordBuilder.Append(randomChar);
                        consonantsCount--;
                    }
                }

                return pseudoWordBuilder.ToString();
            }
            public static string GeneratePseudoText(int wordsCount, int vowelsCount, int consonantsCount, int maxLength)
            {
                StringBuilder pseudoTextBuilder = new StringBuilder();

                for (int i = 0; i < wordsCount; i++)
                {
                    string pseudoWord = GeneratePseudoWord(vowelsCount, consonantsCount, maxLength);
                    pseudoTextBuilder.Append(pseudoWord);
                    pseudoTextBuilder.Append(" ");
                }

                return pseudoTextBuilder.ToString().Trim();
            }

        }
    }

    namespace PseudoTextEN
    {
        public class Text
        {
            private int vowelsCount;
            private int consonantsCount;
            private int maxLength;
            public int VowelsCount
            {
                get { return vowelsCount; }
                set { vowelsCount = value; }
            }
            public int ConsonantsCount
            {
                get { return consonantsCount; }
                set { consonantsCount = value; }
            }
            public int MaxLength
            {
                get { return maxLength; }
                set { maxLength = value; }
            }
            public Text() { }
            public Text(int vowelsCount, int consonantsCount, int maxLength)
            {
                this.vowelsCount = vowelsCount;
                this.consonantsCount = consonantsCount;
                this.maxLength = maxLength;
            }
            private static char GetRandomChar(char[] chars)
            {
                Random random = new Random();
                int index = random.Next(chars.Length);
                return chars[index];
            }
            public static string GeneratePseudoWord(int vowelsCount, int consonantsCount, int maxLength)
            {
                char[] vowels = { 'a', 'e', 'y', 'u', 'i', 'o' };
                char[] consonants = { 'q', 'z', 'w', 's', 'x', 'd', 'c', 'r',
                                      'f', 'v', 't', 'g', 'b', 'h', 'n', 'j',
                                      'm', 'k', 'l', 'p' };

                Random random = new Random();
                int length = random.Next(1, maxLength + 1);

                StringBuilder pseudoWordBuilder = new StringBuilder();

                for (int i = 0; i < length; i++)
                {
                    if ((vowelsCount > 0 && consonantsCount > 0) || pseudoWordBuilder.Length == 0)
                    {
                        char randomChar = random.Next(2) == 0 ? GetRandomChar(vowels) : GetRandomChar(consonants);
                        pseudoWordBuilder.Append(randomChar);

                        if (Array.IndexOf(vowels, randomChar) >= 0)
                            vowelsCount--;
                        else
                            consonantsCount--;
                    }
                    else if (vowelsCount > 0)
                    {
                        char randomChar = GetRandomChar(vowels);
                        pseudoWordBuilder.Append(randomChar);
                        vowelsCount--;
                    }
                    else
                    {
                        char randomChar = GetRandomChar(consonants);
                        pseudoWordBuilder.Append(randomChar);
                        consonantsCount--;
                    }
                }
                return pseudoWordBuilder.ToString();
            }
            public static string GeneratePseudoText(int wordsCount, int vowelsCount, int consonantsCount, int maxLength)
            {
                StringBuilder pseudoTextBuilder = new StringBuilder();

                for (int i = 0; i < wordsCount; i++)
                {
                    string pseudoWord = GeneratePseudoWord(vowelsCount, consonantsCount, maxLength);
                    pseudoTextBuilder.Append(pseudoWord);
                    pseudoTextBuilder.Append(" ");
                }
                return pseudoTextBuilder.ToString().Trim();
            }
        }
    }
}