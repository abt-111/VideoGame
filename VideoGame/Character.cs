namespace VideoGame
{
    internal class Character
    {
        public int lifePoints, attackPoints, defensePoints;
        public string name;

        public bool IsAlive()
        {
            if(lifePoints <= 0)
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
            enemy.lifePoints -= (attackPoints - enemy.defensePoints);
        }
    }
}
