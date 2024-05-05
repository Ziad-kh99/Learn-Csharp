class Project1
{
    public static void Run()
    {
        string? readResult;
        bool validInteger = false;
        int result;

        Console.WriteLine("Enter an integer value between 5 and 10:");

        do {
            readResult = Console.ReadLine();

            validInteger = int.TryParse(readResult, out result);

            if(validInteger)
            {
                if (result >= 5 && result <= 10)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer value in range 5 up to 10.");
                    validInteger = false;
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid, please try again!");
            }
        } while (validInteger == false);

        Console.WriteLine("You entered value accepted");
    }
}