namespace Mod11
{
    public class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }

        public void Dispose()
        {
            Console.WriteLine($"The play '{Title}' by {Author} is being disposed.");
            GC.SuppressFinalize(this);
        }

        ~Play()
        {
            Dispose();
        }
    }

}
