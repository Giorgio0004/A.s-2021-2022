namespace Song
{
    public class Song
    {
        public Song(string  title,int duration)
        {
            Title = title;
            Duration = duration;
        }

        public string Title { get; set; }
        public int Duration { get; set; }
    }
}
