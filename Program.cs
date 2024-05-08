using AbstraindoJogoRpg.src.Entites;

Kninght heroi = new Kninght("Arus",2,"Kninght");
Wizard wizard = new Wizard("Janne",2,"Wizard");
Ninja ninja = new Ninja("Wedge",2,"Ninja");

Console.WriteLine(wizard.Attack(1));
Console.WriteLine(wizard.Attack(9));


Console.WriteLine(ninja.Attack(1));
Console.WriteLine(ninja.Attack(9));
