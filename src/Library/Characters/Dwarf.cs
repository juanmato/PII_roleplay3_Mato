namespace Ucu.Poo.RoleplayGame
{
    public class Dwarf : Hero
    {
        public Dwarf(string name) : base(name, 100)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}