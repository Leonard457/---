namespace My_Protject
{
    public class Word
    {
        /// <summary>
        /// Исходное слово
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Перевод исходного слова
        /// </summary>
        public string Target { get; set; }

        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
}
