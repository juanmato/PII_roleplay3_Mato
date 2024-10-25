namespace Ucu.Poo.RoleplayGame
{
    public class Archer : Hero
    {
        public Archer(string name) : base(name, 80)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}    
