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
            
        }
    public class Person
        {
        public string? Name{get;set;}
        public int Age{get;set;}
        }




    }

}
