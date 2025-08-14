namespace LoginSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            string userName = "admin";
            string password = "1234";
            bool loginSuccessful = false;

            while (test <= 3 && !loginSuccessful)
            {
                Console.WriteLine("Plase enter name");
                string enteredName = Console.ReadLine();
                Console.WriteLine("Plase enter Password");
                string enteredPassword = Console.ReadLine();

                if (enteredName == userName && enteredPassword == password)
                {
                    Console.WriteLine("Login successful!");
                    loginSuccessful = true;
                }
                else
                {
                    test++;
                    if (test < 3)
                    {
                        Console.WriteLine($"Incorrect credentials. You have {3 - test} attempt(s) remaining.");
                    }
                }
            }
            if (!loginSuccessful)
            {
                Console.WriteLine("Too many Failed");
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Time");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hello , welcome to th ststem");
                        break;
                    case "2":
                        Console.WriteLine($"Current date and time: {DateTime.Now}");
                        break;
                    case "3":
                        Console.WriteLine(" goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nYou have completed 3 actions. Program ending.");
            }
        }
    }
}
