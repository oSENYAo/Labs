namespace Labs.FirstLab
{
    public class InputText
    {
        private readonly char _standartSymbol = '#';
        

        public void Work()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // разделители слов
            char[] delimiters = { ' ', '\t', '\n', '\r', ',', '.', '!', '?' };
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            string replacedWord = "";
            foreach (char c in longestWord)
            {
                replacedWord += "#";
            }

            string result = text.Replace(longestWord, replacedWord);
            Console.WriteLine(result);

        }
    }
}
