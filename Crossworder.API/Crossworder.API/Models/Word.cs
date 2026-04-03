namespace Crossworder.API.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public string[] Clues { get; set; } = Array.Empty<string>();
        public int Length => Text.Length;
        public char FirstLetter => Text.FirstOrDefault();
        public char LastLetter => Text.LastOrDefault();
    }
}