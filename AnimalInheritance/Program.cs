// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
class Cat : Animal
{
    public string breed;  // accessible from any class
    protected int height;  //accessible from derived classes
    protected int weight;

    public void setHeight(int height)
    {
        this.height = height;
    }
    public virtual int getHeight()
    {
        return height;
    }
    public void setWeight(int weight)
    {
        this.weight = weight;
    }
    public virtual int getWeight()
    {
        return weight;
    }

    // access name through base because it is private
    public override string getName()
    {
        return base.getName();
    }

    // access type directly because it is protected and this is a derived class
    public override string getType()
    {
        return type;
    }

}
class Program
{

    static void Main(string[] args)
    {
        // object of the base class Animal
        Animal critter = new Animal();
        critter.setName("Sparky");
        critter.setType("Dog");
        // color is a public field and can be accessed anywhere
        critter.color = "White";

        Console.WriteLine("Animal Information...");
        Console.WriteLine($"Name: {critter.getName()}");
        Console.WriteLine($"Type: {critter.getType()}");
        Console.WriteLine($"Color: {critter.color}");
        Console.WriteLine();

        // Instead of Horse I put Cat
        Cat kitty = new Cat();
        kitty.setName("Whiskers");
        kitty.setType("Cat");
        // color is a public field and can be accessed anywhere
        kitty.color = "White";
        // breed is a public field
        kitty.breed = "Siamese";
        kitty.setHeight(10);
        kitty.setWeight(9);

        Console.WriteLine("Cat Information...");
        Console.WriteLine($"Name= {kitty.getName()}");
        Console.WriteLine($"Type= {kitty.getType()}");
        Console.WriteLine($"Color= {kitty.color}");
        Console.WriteLine($"Breed= {kitty.breed}");
        Console.WriteLine($"Height= {kitty.getHeight()} inches");
        Console.WriteLine($"Weight= {kitty.getWeight()} Ibs");

        Console.ReadLine(); // pauses end of program display
    }

}

