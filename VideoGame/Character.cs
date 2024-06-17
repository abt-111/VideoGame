namespace VideoGame
{
    internal class Character
    {
        public int lifePoints, attackPoints, defensePoints;
        public string name;

        public bool IsAlive()
        {
            if (lifePoints <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Attack(Character enemy)
        {
            int damages = attackPoints - enemy.defensePoints;

            // Un attaquant ne peut pas rajouter de points de vie à un attaqué
            if (damages < 0) damages = 0;

            enemy.lifePoints -= damages;
        }
    }
}
