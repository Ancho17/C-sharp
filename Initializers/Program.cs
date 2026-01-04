namespace Initializers
{
class TrySomething
    {
    static void Main()
        {
        Cat cat = new() {Name = "Jerald"};
        System.Console.WriteLine(cat.Name);
        List<Cat> cats = [
            new() {Name="Jhon",Age=3}
        ];
        System.Console.WriteLine(cats[0].Name);
        Dictionary<int,string> numbers = new(){
        [0]="Elephant",
        [1]="Snake"
        };
        System.Console.WriteLine(numbers[0]);
       
        
        }
        public class Cat
        {
        public required string? Name{get;set;}
        public int Age{get;set;}
      
        
        
        }
    }
}
