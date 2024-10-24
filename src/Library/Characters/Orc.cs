namespace Ucu.Poo.RoleplayGame
{
    public class Orc : Enemy
    {
        public Orc(string name) : base(name, 80, 50) 
            this.AddItem(new Axe()); 
        }
    }
}