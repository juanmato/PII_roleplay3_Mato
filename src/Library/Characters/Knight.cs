namespace Ucu.Poo.RoleplayGame
{
    public class Dwarf : Character
    {
        public Dwarf(string name) : base(name, 100)
        {
            this.AddItem(new Armor());
            this.AddItem(new Shield());
            this.AddItem(new Sword());
        }
    }
}



