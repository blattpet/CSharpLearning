namespace Exercise1
{
    class Programm
    {
        static void Main(string[] args)
        {
            TaskOne();
            //TaskTwo();
            //TaskThree();
            //TaskFour();
        }

        public static void TaskOne()
        {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine("The number was: " + input);
        }

        public static void TaskTwo()
        {
            Console.WriteLine("Enter first number:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number:");
            int second = int.Parse(Console.ReadLine());

            int max = (second > first) ? second : first;
            Console.WriteLine("The bigger number is: " + max);
        }

        public static void TaskThree()
        {
            Console.WriteLine("Enter image width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter image height");
            int height = int.Parse(Console.ReadLine());
            string dimension = (width > height) ? "landscape" : "portrait";
            Console.WriteLine(dimension);
        }

        public static void TaskFour()
        {
            Console.WriteLine("Enter a speed limit for the camera:");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed from car:");
            int carSpeed = int.Parse(Console.ReadLine());

            if (speedLimit > carSpeed)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demerit = (carSpeed - speedLimit) / 5;
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + demerit);
                }
            }
        }
    }
}
