namespace Ucu.Poo.RoleplayGame
{
    public class Enemy : Character
    {
        public int VictoryPoints { get; private set; }

        public Enemy(string name, int initialHealth, int victoryPoints) : base(name, initialHealth)
        {
            this.VictoryPoints = victoryPoints;
        }
    }
}