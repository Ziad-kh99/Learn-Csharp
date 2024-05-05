class Project2
{
    public static void Run()
    {
        string? readResult;
        bool validEntry = false;

        Console.WriteLine("Please enter you role (Administrator / Manager / User):");

        do {
            readResult = Console.ReadLine().Trim().ToLower();

            switch (readResult)
            {
                case "administrator":
                    validEntry = true;
                    break;
                case "manager":
                    validEntry = true;
                    break;
                case "user":
                    validEntry = true;
                    break;
                default:
                    Console.WriteLine("Please enter a valid role");
                    break;
            }

        } while (validEntry == false);

        Console.WriteLine($"Your role {readResult} accepted.");
    }
}