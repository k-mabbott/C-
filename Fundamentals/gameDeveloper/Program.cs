// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Game Time!");

Random rand = new Random();

Enemy Ficus = new Enemy("Ficus");

Attack VineWhip = new Attack("VineWhip", 20);
Attack Dig = new Attack("Dig", 10);
Attack BulletSeed = new Attack("BulletSeed", rand.Next(5,21));

Ficus.AddAttack(VineWhip);
Ficus.AddAttack(Dig);
Ficus.AddAttack(BulletSeed);

Console.WriteLine(Ficus.RandomAttack());