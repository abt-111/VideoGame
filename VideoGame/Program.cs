using VideoGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        Character goodGuy = new Character();
        Character badGuy = new Character();

        // Initialisation des objets
        goodGuy.name = "Goku";
        goodGuy.lifePoints = 10;
        goodGuy.attackPoints = 9001;
        goodGuy.defensePoints = 9000;

        badGuy.name = "Végéta";
        badGuy.lifePoints = 10;
        badGuy.attackPoints = 9001;
        badGuy.defensePoints = 9000;

        // Mise en scène
        while (goodGuy.IsAlive() && badGuy.IsAlive())
        {
            if (random.Next(2) == 0)
            {
                goodGuy.Attack(badGuy);
            }
            else
            {
                badGuy.Attack(goodGuy);
            }
        }

        // Affichage
        if (goodGuy.IsAlive())
        {
            Console.WriteLine($"{goodGuy.name} a gagné.");
        }
        else
        {
            Console.WriteLine($"{badGuy.name} a gagné.");
        }
    }
}