// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World! Game Time!");

// Random rand = new Random();

MeleeFighter Ninja = new MeleeFighter("Ninja");
RangedFighter RobinHood = new RangedFighter("Robin Hood");
MagicCaster Dumbledore = new MagicCaster("Dumbledore");
// foreach(Attack atk in Ninja.AttackList )
// {
//     Console.WriteLine(atk.Name);
// }
// Ninja.AttackList.ForEach(a => Console.WriteLine(a));
Ninja.PerformAttack(RobinHood, Ninja.Kick);
Ninja.Rage(Dumbledore);
Ninja.Rage(Dumbledore);
RobinHood.PerformAttack(Ninja, RobinHood.Arrow);
RobinHood.Dash(Ninja);
RobinHood.PerformAttack(Ninja, RobinHood.Arrow);
Dumbledore.PerformAttack(Ninja, Dumbledore.Fireball);
Dumbledore.Heal(RobinHood);
Ninja.Rage(Dumbledore);
Dumbledore.PerformAttack(Ninja, Dumbledore.Lightingbolt);
Ninja.PerformAttack(Dumbledore, Ninja.Punch);
Dumbledore.Heal(Dumbledore);

// Ninja.Rage(RobinHood);
// Ninja.Rage(RobinHood);
// Ninja.PerformAttack(RobinHood, Ninja.AttackList[1]);

