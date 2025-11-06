// Role playing game battle (Do and while loop)
int heroHealth = 10, monsterHealth = 10;
Random random = new Random();

do
{
    //Hero attacks
    int attack = random.Next(1,11);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");

    if(monsterHealth > 0)
    {
        //Monster attacks
        attack = random.Next(1,11);
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }

    if(monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    else if(heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }

    attack = random.Next(1, 11);
}

while(heroHealth > 0);