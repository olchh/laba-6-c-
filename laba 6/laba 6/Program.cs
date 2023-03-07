namespace laba_6
{
    class Animal
    {
        public string name;
        public string food;
        public string location;

        public Animal(string name, string food, string location)
        {
            this.name = name;
            this.food = food;
            this.location = location;
        }

        public virtual void makeNoise() { }
        public virtual void Eat() { }
        public virtual void Sleep() { }
    }
    class Dog : Animal
    {
        public Dog(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} гав");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушоетб: " + food) ;
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спитб");
        }


    }
    class Cat : Animal
    {
        public Cat(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} мяу");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушоетб: " + food);
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спитб");
        }
    }
    class Horse: Animal
    {
        public Horse(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} хырхыр");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушоетб: " + food);
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спитб");
        }
    }

    class Vetirinar
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine(animal.name + " - живность у врача");
            Console.WriteLine("кушоетб: " + animal.food);
            Console.WriteLine("живетб: " + animal.location);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetirinar vetirinar = new Vetirinar();

            Dog dog = new Dog("Бобик", "для бобиков", "у бабушки");
            Cat cat = new Cat("Багирка", "для багирок", "у меня");
            Horse horse = new Horse("Фиби", "для фиби", "у кати");

            vetirinar.treatAnimal(dog);
            Console.WriteLine();
            vetirinar.treatAnimal(cat);
            Console.WriteLine();
            vetirinar.treatAnimal(horse);

            Console.ReadLine();
        }
    }
}