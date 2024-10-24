namespace Ucu.Poo.RoleplayGame
{
    public class Hero : Character
    {
        public int VictoryPoints { get; private set; } = 0;

        public Hero(string name, int initialHealth) : base(name, initialHealth)
        {
        }

        public void GainVictoryPoints(int points)
        {
            this.VictoryPoints += points;
        }

        public void DefeatEnemy(Enemy enemy)
        {
            this.GainVictoryPoints(enemy.VictoryPoints);
        }
    }
}