using System.Xml;
using System.Xml.Serialization;
namespace XMLer
{
public class XMiLier
    {
    static void Main()
        {
        Person? Angel = new(){Name="Angel",Age=22};
        
        var serialize = new XmlSerializer(typeof(Person));
        string path = "/workspaces/C-sharp/XML/Thing.xml";

            using FileStream stream = new(path,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
            serialize.Serialize(stream,Angel);
        using FileStream reader = new(path,FileMode.Open,FileAccess.Read,FileShare.Read);
        Person? info;
        info = (Person) serialize.Deserialize(reader);
        System.Console.WriteLine("Name is " +info.Name);
        System.Console.WriteLine("Age is " +info.Age);
            
        }
    public class Person
        {
        public string? Name{get;set;}
        public int Age{get;set;}
        }




    }

}
