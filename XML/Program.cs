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

            using TextWriter finish = new StreamWriter("Thing.xml");
            serialize.Serialize(finish,Angel);
            
        }
    public class Person
        {
        public string? Name{get;set;}
        public int Age{get;set;}
        }




    }

}
