#region Version 1 of Code:
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (var number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
        bool found = true;
    }

}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");
*/

#endregion


#region Version 2 of Code:

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (var number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

#endregion