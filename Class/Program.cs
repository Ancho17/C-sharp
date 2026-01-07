namespace Class
{
    class MyClass
    {
        static void Main()
        {
            Cat Doris = new("Doris", 3);//Hy
            System.Console.WriteLine($"The name is {Doris.Name} it is {Doris.Age} and it has {Doris.Lives} lives.");
            Doris.MakeSound();
            Doris.Love();
            

            Dog Bary = new("Bary",4);
            System.Console.WriteLine($"The name is {Bary.Name} and is {Bary.Age} years old it's tail is {Bary.Tail}.");
            Bary.MakeSound();
            Bary.Love();
            
            Pet[] All = [Bary,Doris];
            foreach(Pet animal in All)
            {
            System.Console.WriteLine(animal.Name);
            }


        }


    }
  
    abstract public class Pet
    {
        
        public string? Name { get; set; }
        public int Age { get; set; }

        public Pet(string name, int age) =>
        (Name, Age) = (name, age);
        virtual public void MakeSound()
        {
            System.Console.WriteLine("The animal is saying: ");
            Sound();
        
        }
        abstract public void Sound();
        



    }
    interface ILove
    {
     void Love();
        
    }

    public class Cat : Pet,ILove
    {
        public Cat(string name, int age)
        : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public int Lives { get; } = 9;
        
        public override void Sound()
        {

            System.Console.WriteLine("*Meow*");
        }
        public void Love()
        {
            System.Console.WriteLine("I love you");
        }
    }
     public class Dog : Pet,ILove
    {
        public Dog(string name, int age)
        : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public string Tail = "wagging";
        
        public override void Sound()
        {

            System.Console.WriteLine("*Wof*");
        }
        public void Love()
        {
            System.Console.WriteLine("I love you");
        }
    }
    


}


