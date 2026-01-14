using System.Xml.Serialization;

namespace Library
{
    
    public class BookShelf
    {
    static void Main()
        {
       Book MobyDick = new(){Name="Moby Dick",Author="Herman Melvin",Pulished=new DateOnly(1851,10,18)};
       var serializer = new XmlSerializer(typeof(Book));
       using TextWriter writer = new StreamWriter("Library.xml",true);
       serializer.Serialize(writer,MobyDick);
       
       
        }
        
    public class Book
        {
            
        [XmlElement("BookName")]
        public string? Name{get;set;}
        [XmlElement("AuthorName")]
        public string? Author{get;set;}
        
        public DateOnly Pulished {get;set;}
        }
    }
}
