using HomWorl.Animal;
Cat cat = new Cat();
Dog dog = new Dog();



List<Animal> list = new List<Animal>()
{
   new Cat() {Name="Cat1", Color="Vang" },
   new Cat() {Name="Cat2", Color="Xanh" },
   new Cat() {Name="Cat3", Color="Do" },
   new Cat() {Name="Cat4", Color="Trang" },
   new Dog() {Name="Dog1", Color="Trang" },
   new Dog() {Name="Dog2", Color="Xanh" },
   new Dog() {Name="Dog3", Color="Tim" },
   new Dog() {Name="Dog4", Color="Den" },
};
list.Where(l => l.Sound().Equals("gau gau")).ToList().ForEach(d => Console.WriteLine(d.Name));

Console.ReadKey();
