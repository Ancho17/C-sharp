using System.Xml.Serialization;

namespace Library
{
    
    public class BookShelf
    {
    static void Main()
        {
       System.Console.WriteLine("Choose to add a book");
       Book BookInfo = new();
       System.Console.Write("Tile: ");
       BookInfo.Name=System.Console.ReadLine();
       System.Console.Write("Author: ");
       BookInfo.Author=System.Console.ReadLine();
       
       while(true){
    try{
       
        System.Console.Write("Date of publishing(year,month,day): "); 
       BookInfo.Pulished = DateOnly.Parse(Console.ReadLine());
       break;
       
       }
       catch(FormatException)
                {
                 System.Console.WriteLine("Correct formating example 1958,07,29");
                }
                
       }
       BookInfo.ID= BookInfo.GetHashCode();
       
       var serializer = new XmlSerializer(typeof(Book));
       string path = "/workspaces/C-sharp/Library/Books/ID";
       
       using FileStream writer = new(path+BookInfo.ID.ToString(),FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write);
       serializer.Serialize(writer,BookInfo);
       
       
        }
        
    public class Book
        {
        [XmlAttribute]
         public int ID{get;set;}
             
        [XmlElement("BookName")]
        public string? Name{get;set;}
        [XmlElement("AuthorName")]
        public string? Author{get;set;}
        
        public DateOnly Pulished {get;set;}

            public override int GetHashCode()
            {
            int result=0;
            foreach(var letter in Name)
                {
                result +=letter+1;
                }
        return result;
            }
        }
    }
}
