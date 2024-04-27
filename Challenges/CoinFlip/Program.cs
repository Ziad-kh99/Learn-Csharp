
Random randomNumberGenerator = new Random();
int flip = randomNumberGenerator.Next(1, 3);
Console.WriteLine($"Result: {(flip == 1 ? "Heads": "Tails")}");

Console.WriteLine($"Result: {(randomNumberGenerator.Next(1, 3) == 1 ? "Heads": "Tails")}");
