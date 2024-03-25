using LingoGame;

namespace WebLingo.Models
{
    public class LingoModel
    {
        public List<LingoWord> Guesses { get; set; } = new List<LingoWord>();
        public int Attempt { get; set; }
        public string? YourIQ { get; set; }
        public bool Finished { get; set; }

        public LingoWord? WordToBeGuessed { get; set; }
    }
}
