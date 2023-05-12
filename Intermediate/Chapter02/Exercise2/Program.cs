namespace Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            post.Title = "Test";
            post.Description = "This is a test with properties.";
            post.Time = DateTime.Now;

            post.UpVoting();    // 1
            post.UpVoting();    // 2
            post.UpVoting();    // 3
            post.UpVoting();    // 4
            post.DownVoting();  // 3

            Console.WriteLine("Title: {0}", post.Title);
            Console.WriteLine("Description: {0}", post.Description);
            Console.WriteLine("Created: {0}", post.Time.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine("Votes: {0}", post.Votes);
        }
    }
}
