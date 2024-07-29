namespace ContosoPettingZoo;


internal class AppServices
{
    static string[] pettingZoo =
    {
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
    };

    const int NumberOfAnimlas = 18;
    static Random random = new Random();

    public static void RandomizeAnimals(string[] animals)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            int r = random.Next(i, animals.Length);

            string temp = animals[i];
            animals[i] = animals[r];
            animals[r] = temp;
        }

    }

    public static string[,] AssignGroups(string[] animals, int groups = 6)
    {
        string[,] animalGroups = new string[groups, NumberOfAnimlas / groups];
        int animalsCounter = 0;

        for (int i = 0; i < animalGroups.GetLength(0); i++)
        {
            for (int j = 0; j < animalGroups.GetLength(1); j++)
            {
                animalGroups[i, j] = animals[animalsCounter++];
            }
        }

        return animalGroups;
    }

    public static void PrintGroup(string[,] group)
    {
        for (int i = 0; i < group.GetLength(0); i++)
        {
            Console.Write($"Group {i + 1}: ");
            for (int j = 0; j < group.GetLength(1); j++)
            {
                Console.Write($"{group[i, j]}, ");
            }
            Console.WriteLine();
        }
    }

    public static void PlanSchoolVisit(string schoolName, int groups = 6)
    {
        RandomizeAnimals(pettingZoo);
        string[,] group = AssignGroups(pettingZoo, groups);
        Console.WriteLine($"{schoolName}");
        PrintGroup(group);
    }
}