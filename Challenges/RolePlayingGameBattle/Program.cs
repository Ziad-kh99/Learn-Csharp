Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int attacks;
int damage;

do
{
    attacks = random.Next(1, 11);
    damage = 0;
    while (attacks > 0)
    {
        monsterHealth--;
        damage++;
        attacks--;
    }
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    attacks = random.Next(1, 11);
    while (attacks > 0)
    {
        heroHealth--;
        damage++;
        attacks--;
    }
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {monsterHealth} health.");
    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }


}while(heroHealth > 0 && monsterHealth > 0);



