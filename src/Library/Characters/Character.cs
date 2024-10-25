namespace Ucu.Poo.RoleplayGame
{
    public abstract class Character : ICharacter
    {
        private int health;
        private List<IItem> items = new List<IItem>();

        public Character(string name, int initialHealth)
        {
            this.Name = name;
            this.health = initialHealth;
        }

        public string Name { get; set; }

        public int Health
        {
            get { return this.health; }
            protected set { this.health = value < 0 ? 0 : value; }
        }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem attackItem)
                    {
                        value += attackItem.AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem defenseItem)
                    {
                        value += defenseItem.DefenseValue;
                    }
                }
                return value;
            }
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public virtual void Cure()
        {
            this.Health = 100;
        }
    }
}