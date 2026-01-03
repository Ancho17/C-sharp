namespace Generic
{
class MyGenericProgram
{
    static void Main()
        {
            Dictionary<string,string> Things =[];
            Things.Add("0","elephant");
            Things.Add("1","cat");
            Things.Add("2","dog");
            ListStuff(Things);
            List<int> numbers = [1,2,3,4];
            List<string> words = ["tower","house","cave"];
            Show(numbers);
            Show(words);
            Try<string> one = new("hey","ho");
            one.DoSmth();

         
        }
    static void ListStuff<T>(Dictionary<string,T> stuff)
        {
        
        foreach(var foo in stuff)
            {
                System.Console.WriteLine(foo);
            }
            
        }
    static void Show<T>(List<T> review)
        {
        foreach(var show in review)
            {
            System.Console.WriteLine(show);
            }
        }
    public class Try<T>
        {
        T Item{get;set;}
        T OtherThing{get;set;}
        public Try(T item,T otherthing)
            {
            Item = item;
            OtherThing = otherthing;
            }

        public void DoSmth()
            {
            System.Console.WriteLine(Item +" "+ OtherThing);
            }
        
        }
        
}
}
