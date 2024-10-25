namespace Ucu.Poo.RoleplayGame
{
    public class Hero : Character
    {
        public int VictoryPoints { get; private set; }

        public Hero(string name, int initialHealth) : base(name, initialHealth)
        {
            this.VictoryPoints = 0;
        }

        public void AddVictoryPoints(int points)
        {
            this.VictoryPoints += points;
        }

        // Override Cure method to heal if VictoryPoints >= 5
        public override void Cure()
        {
            if (this.VictoryPoints >= 5)
            {
                base.Cure();
            }
        }
    }
}