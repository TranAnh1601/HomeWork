using Game.HomWork;

Console.WriteLine("Nhap Ten SuperMan:");
string nameSuper = Console.ReadLine().Trim();

Console.WriteLine("Nhap Ten Monter:");
string nameMonter = Console.ReadLine().Trim();
Console.WriteLine("Nhap Hp Monter:");
bool check = int.TryParse(Console.ReadLine().Trim(), out int hpMonter) && hpMonter > 0;
while(!check)
{
    Console.WriteLine("Hp Monter lon hon 0");
    check = int.TryParse(Console.ReadLine().Trim(), out  hpMonter) && hpMonter > 0;
}

SuperMan superMan = new SuperMan(nameSuper);
Monster monster = new Monster(nameMonter,hpMonter);

do
{
    superMan.Attack(monster);
    Console.WriteLine($"Ten SuperMan:{superMan.Name,5} Mau:{superMan.Hp}");
    Console.WriteLine($"Ten Monter:{monster.Name,5} Mau:{monster.Hp}");  
} while (superMan.Hp > 0 && monster.Hp > 0);

Console.ReadKey();