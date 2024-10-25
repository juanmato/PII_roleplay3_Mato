namespace Ucu.Poo.RoleplayGame
{
    public class Encounter
    {
        private List<Hero> heroes;
        private List<Enemy> enemies;

        public Encounter(List<Hero> heroes, List<Enemy> enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }

        public void DoEncounter()
        {
            while (this.heroes.Count > 0 && this.enemies.Count > 0)
            {
                // Enemies attack first
                EnemiesAttack();

                // Remove dead heroes
                RemoveDeadHeroes();

                // Heroes attack if any are alive
                if (this.heroes.Count > 0)
                {
                    HeroesAttack();

                    // Remove dead enemies
                    RemoveDeadEnemies();

                    // Heroes heal if they have 5 or more VictoryPoints
                    foreach (Hero hero in this.heroes)
                    {
                        if (hero.VictoryPoints >= 5)
                        {
                            hero.Cure();
                        }
                    }
                }
            }
        }

        private void EnemiesAttack()
        {
            int heroCount = this.heroes.Count;
            int enemyCount = this.enemies.Count;

            for (int i = 0; i < enemyCount; i++)
            {
                Enemy enemy = this.enemies[i];
                Hero targetHero;

                if (heroCount == 1)
                {
                    // All enemies attack the single hero
                    targetHero = this.heroes[0];
                }
                else
                {
                    // Enemies attack heroes in order
                    int targetIndex = i % heroCount;
                    targetHero = this.heroes[targetIndex];
                }

                targetHero.ReceiveAttack(enemy.AttackValue);
            }
        }

        private void RemoveDeadHeroes()
        {
            List<Hero> aliveHeroes = new List<Hero>();

            foreach (Hero hero in this.heroes)
            {
                if (hero.Health > 0)
                {
                    aliveHeroes.Add(hero);
                }
            }

            this.heroes = aliveHeroes;
        }

        private void HeroesAttack()
        {
            foreach (Hero hero in this.heroes)
            {
                foreach (Enemy enemy in this.enemies)
                {
                    if (enemy.Health > 0)
                    {
                        enemy.ReceiveAttack(hero.AttackValue);

                        // If enemy is defeated, hero gains VictoryPoints
                        if (enemy.Health == 0)
                        {
                            hero.AddVictoryPoints(enemy.VictoryPoints);
                        }
                    }
                }
            }
        }

        private void RemoveDeadEnemies()
        {
            List<Enemy> aliveEnemies = new List<Enemy>();

            foreach (Enemy enemy in this.enemies)
            {
                if (enemy.Health > 0)
                {
                    aliveEnemies.Add(enemy);
                }
            }

            this.enemies = aliveEnemies;
        }
    }
}
