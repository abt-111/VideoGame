namespace VideoGame
{
    internal class Character
    {
        public int LifePoints { get; set; }
        public int Attack { get; }
        public int Defense { get; }
        public string Name { get; }
        public bool IsAlive => LifePoints > 0;

        public Character(int lifePoint, int attack, int defense, string name)
        {
            LifePoints = lifePoint;
            Attack = attack;
            Defense = defense;
            Name = name;
        }

        public void AttackEnemy(Character enemy)
        {
            int damages = Attack - enemy.Defense;

            // Un attaquant ne peut pas rajouter de points de vie à un attaqué
            if (damages < 0) damages = 0;

            enemy.LifePoints -= damages;
        }
    }
}
