

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            //TaskTwo();
            //TaskThree();
            //TaskFour();
            //TaskFive();
        }

        public static void TaskOne()
        {
            Console.Write("Enter some numbers in shape like this 2-3-4-5: ");
            var inputString = Console.ReadLine();
            var outputString = CheckConsecutive(inputString);
            Console.WriteLine(outputString);
        }

        private static string CheckConsecutive(string inputString)
        {
            var numbers = inputString.Split('-');
            var number = Convert.ToInt32(numbers[0]);
            var isConsecutive = false;

            for (var i = 1; i < numbers.Length; i++)
            {
                var nextNumber = Convert.ToInt32(numbers[i]);
                if (number + 1 == nextNumber)
                {
                    number = nextNumber;
                    isConsecutive = true;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }
            }

            return (isConsecutive) ? "Consecutive" : "Not Consecutive";
        }

        public static void TaskTwo()
        {

        }

        public static void TaskThree()
        {

        }

        public static void TaskFour()
        {

        }

        public static void TaskFive()
        {

        }
    }
}