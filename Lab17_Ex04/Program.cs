Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
    animal.Speak();  // เพิ่มการเรียก Speak() สำหรับการพูดของสัตว์
}

interface IMovable
{
    public void Move();
}

interface ISpeakable
{
    public void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    abstract public void Move();
    abstract public void Speak();  // ต้อง implement เมธอด Speak()
}

class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Dog move by running on the ground");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Dog barks");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Fish move by swimming in the water");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Fish makes bubbles");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Bird move by flying in the air");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Bird chirps");
    }
}
