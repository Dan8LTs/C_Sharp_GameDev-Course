int playerHealth = 100;
int playerDamage = 50;
int enemyHealth = 5000;
int enemyDamage = 10;

while (playerHealth > 0 && enemyHealth > 0)
{
    playerHealth -= enemyDamage;
    enemyHealth -= playerDamage;

    Console.WriteLine(playerHealth + " player.");
    Console.WriteLine(enemyHealth + " enemy.");

    if (playerHealth <= 0 && enemyHealth <= 0)
    {
        Console.WriteLine("Draw.");
    }
    else if (enemyHealth <= 0)
    {
        Console.WriteLine("Player victory.");
    }
    else if (playerHealth <= 0)
    {
        Console.WriteLine("Enemy victory");
    }
}