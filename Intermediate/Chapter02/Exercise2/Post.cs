namespace Exercise2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public int Votes { get; private set; }

        public void UpVoting()
        {
            Votes++;
        }

        public void DownVoting()
        {
            Votes--;
        }
    }
}
