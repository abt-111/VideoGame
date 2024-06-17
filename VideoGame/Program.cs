namespace VideoGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            // Initialisation des objets
            Character goodGuy = new Character(10, 9001, 9000, "Goku");
            Character badGuy = new Character(10, 9001, 9000, "Végéta");

            // Mise en scène
            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (random.Next(2) == 0)
                {
                    goodGuy.AttackEnemy(badGuy);
                }
                else
                {
                    badGuy.AttackEnemy(goodGuy);
                }
            }

            // Affichage
            if (goodGuy.IsAlive)
            {
                Console.WriteLine($"{goodGuy.Name} a gagné.");
            }
            else
            {
                Console.WriteLine($"{badGuy.Name} a gagné.");
            }
        }
    }
}