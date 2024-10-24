namespace Ucu.Poo.RoleplayGame
{
    public class Dwarf : Character
    {
        public Dwarf(string name) : base(name, 80)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}    
