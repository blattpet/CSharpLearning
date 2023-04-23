namespace Exercise2
{
    class Programm
    {
        static void Main(string[] args)
        {
            //TaskOne();
            //TaskTwo();
            //TaskThree();
            TaskFour();
            //TaskFive();
        }

        public static void TaskOne()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Divisible by 3 count: " + count);
        }

        public static void TaskTwo()
        {
            var sumOfNumber = 0;
            while (true)
            {
                Console.Write("Enter a number to the sum: ");
                var value = Console.ReadLine();
                if ("ok" != value)
                {
                    sumOfNumber += int.Parse(value);
                    continue;
                }
                break;
            }

            Console.WriteLine("The sum is: " + sumOfNumber);
        }

        public static void TaskThree()
        {
            Console.Write("Enter a number for factorial calculation: ");
            var number = int.Parse(Console.ReadLine());

            var factorSum = 1;
            for (var i = number; i >= 1; i--)
            {
                factorSum *= i;
            }

            Console.WriteLine("!{0} = {1}", number, factorSum);
        }

        public static void TaskFour()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 10);
            Console.WriteLine("Guess the secret number between 1 and 10");

            var chances = 4;
            while (true)
            {
                Console.Write("You have {0} chances left: ", chances);
                var guess = int.Parse(Console.ReadLine());
                if (guess != secretNumber && chances > 1)
                {
                    chances--;
                    continue;
                }
                else if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost!");
                    break;
                }
            }

            Console.WriteLine("The secret number: " + secretNumber);
        }

        public static void TaskFive()
        {
            Console.WriteLine("Enter a serie of numbers lik this: 5, 4, 3, 6");
            var input = Console.ReadLine();
            string[] subs = input.Split(',');

            var maxNumber = 0;
            foreach (var s in subs)
            {
                var newNumber = int.Parse(s);
                if (newNumber > maxNumber)
                {
                    maxNumber = newNumber;
                }
            }

            Console.WriteLine("That was you maximum: " + maxNumber);
        }
    }
}
