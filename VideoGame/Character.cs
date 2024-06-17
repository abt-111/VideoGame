using System.Text;

namespace VideoGame
{
    internal class Character
    {
        public int lifePoints, attackForce, defenseForce;
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
            enemy.lifePoints -= (attackForce - enemy.defenseForce);
        }
    }
}
