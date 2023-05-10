namespace Exercise1
{

    class Program
    {
        static void Main(string[] args) 
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("This is a stopwatch!\n" +
                "The valid inputs are:\n" +
                "0 for start\n" +
                "1 for stop\n" +
                "2 for exit");

            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Input please: ");
                var inputValue = int.Parse(Console.ReadLine());

                switch (inputValue)
                {
                    case (int) State.Start:
                        sw.Start();
                        break;
                    case (int) State.Stop: 
                        sw.Stop(); 
                        break;
                    case (int) State.Exit:
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}