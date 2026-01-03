namespace Initializers
{
class TrySomething
    {
    static void Main()
        {
        var cat = new Cat{Name="Jerald",Age=3};
        System.Console.WriteLine(cat.Name);
       
        
        }
        public class Cat
        {
        public string? Name{get;set;}
        public int Age{get;set;}
        public Cat(){}
        
        
        }
    }
}
