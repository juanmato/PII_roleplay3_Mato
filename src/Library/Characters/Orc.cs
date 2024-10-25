namespace Ucu.Poo.RoleplayGame
{
    public class Orc : Enemy
    {
        public Orc(string name) : base(name, 130, 50) // El orco tiene 100 de vida y otorga 50 puntos de victoria
        {
            // Añadimos algunos items que el orco pueda utilizar
            this.AddItem(new Axe());   // Un hacha que incrementa su poder de ataque
            this.AddItem(new Shield()); // Un escudo que incrementa su defensa
        }
    }
}