namespace Practise
{
class Base
    {
        static void Main()
        {
          
        List<Person> people = new(3);
        
        for(int i=0;i<3;i++)
            {
            Person temp = new();
            temp.Name=System.Console.ReadLine();
            people.Add(temp);
            }
            foreach(var person in people)
            {
            System.Console.WriteLine(person.Name);
            }


        }
    }
     public class Person
    {
    public string? Name {get;set;}
    }
}
