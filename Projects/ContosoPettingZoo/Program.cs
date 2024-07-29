using ContosoPettingZoo;



AppServices.PlanSchoolVisit("School A");
AppServices.PlanSchoolVisit("School B", 3);
AppServices.PlanSchoolVisit("School C", 2);

#region Test:
/*

AppServices.RandomizeAnimals(animals: pettingZoo);
string[,] result  = AppServices.AssignGroups(pettingZoo);

for(int i = 0; i < result.GetLength(0); i++)
{
    for(int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write($"{result[i, j]}, ");
    }
    Console.WriteLine("");
}
    */
#endregion


