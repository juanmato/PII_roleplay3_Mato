namespace LibraryTests
{
    using NUnit.Framework;
    using Ucu.Poo.RoleplayGame; // Asumiendo que aquí tienes tu clase Dwarf y sus dependencias

    public class TestsDwarf
    {
        private Dwarf dwarf;

        [SetUp]
        public void Setup()
        {
           
            dwarf = new Dwarf("Seba");
        }

        [Test]
        public void DwarfCureTest()
        {
            // Simulación de daño
            dwarf.ReceiveAttack(120);  // El ataque debe reducir la vida por debajo de 0

            // Curar al enano
            dwarf.Cure();

            // Verificación de que la salud vuelve a 100
            Assert.That(dwarf.Health, Is.EqualTo(100));
        }

        [Test]
        public void DwarfReceiveAttackTest()
        {
            // Verificar que recibe el ataque y se reduce la vida correctamente
            int initialHealth = dwarf.Health;
            dwarf.ReceiveAttack(50);  // Ataque con poder 50

            // Verificación de que la vida haya bajado (dependiendo de la defensa)
            Assert.That(dwarf.Health, Is.LessThan(initialHealth));
        }

        [Test]
        public void DwarfAddItemTest()
        {
            int initialAttackValue = dwarf.AttackValue;

            // Añadir un nuevo objeto de ataque
            dwarf.AddItem(new Axe());  // Suponiendo que Axe incrementa AttackValue

            // Verificación de que el valor de ataque haya aumentado
            Assert.That(dwarf.AttackValue, Is.GreaterThan(initialAttackValue));
        }

        [Test]
        public void DwarfRemoveItemTest()
        {
            dwarf.AddItem(new Axe());  // Añadir objeto
            int attackWithItem = dwarf.AttackValue;

            // Remover el objeto
            dwarf.RemoveItem(new Axe());  // Suponiendo que Axe afecta AttackValue

            // Verificación de que el valor de ataque haya disminuido
            Assert.That(dwarf.AttackValue, Is.LessThan(attackWithItem));
        }
    }
}
