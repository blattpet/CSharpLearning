namespace Exercise3
{
    class Programm
    {
        static void Main(string[] args)
        {
            //DemoList();

            TaskOne();
            //TaskTwo();
            //TaskThree();
            //TaskFour();
            //TaskFive();
        }

        public static void DemoList()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("First index of 1 is: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1 is: " + numbers.LastIndexOf(1));

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
                Console.WriteLine(number);
        }


        public static void TaskOne()
        {
            var friends = new List<string>();

            while (true)
            {
                Console.Write("Add a friend: ");
                string friend = Console.ReadLine();

                if (!string.IsNullOrEmpty(friend))
                {
                    friends.Add(friend);
                    continue;
                }
                break;
            }

            if (friends.Count == 1)
            {
                Console.WriteLine("{0} likes your post", friends[0]);
            }
            else if (friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} likes your post", friends[0], friends[1]);
            }
            else
            {
                Console.WriteLine("{0} and {1} and {2} more people likes your post",
                    friends[0], friends[1], friends.Count() - 2);
            }
        }

        public static void TaskTwo()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();

            var nameReverse = new char[name.Length];
            for (var i = 0; i < name.Length; i++)
            {
                nameReverse[i] = char.ToLower(name[i]);
            }

            Array.Reverse(nameReverse);
            string reverseName = "";

            foreach (char c in nameReverse)
            {
                reverseName += c;
            }
            Console.WriteLine("Reverse: " + reverseName);
        }

        public static void TaskThree()
        {
            var numbers = new int[5];
            var counter = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                var number = int.Parse(Console.ReadLine());

                if (!numbers.Contains(number))
                {
                    numbers[counter] = number;
                    counter++;
                    if (counter == 5)
                    {
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Number already in list! ");
                    continue;
                }
            }

            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        public static void TaskFour()
        {

        }

        public static void TaskFive()
        {

        }
    }
}
