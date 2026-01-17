using System.Xml.Serialization;

namespace Library
{
    
    public class BookShelf
    {
    static void Main()
        {
        System.Console.Write("Choose an action sh-search or add: ");
       string action =Console.ReadLine();
       switch(action){
        case "add"://this action add an xml file in my book folder with the information about the book
       System.Console.WriteLine("Choose to add a book");
       Book BookInfo = new();//declare the new book
       System.Console.Write("Tile: ");
       BookInfo.Name=System.Console.ReadLine();//input title
       System.Console.Write("Author: ");
       BookInfo.Author=System.Console.ReadLine();//input author
       
       while(true){
    try{
       
        System.Console.Write("Date of publishing(year,month,day): "); 
       BookInfo.Pulished = DateOnly.Parse(Console.ReadLine());//input date
       break;//the program will exith the while loop only if the date is correctly inputed
       
       }
       catch(FormatException)//the formationg of the date could be wrong so catch is suppose to prevent the program from crashing
                {
                 System.Console.WriteLine("Correct formating example 1958,07,29");
                }
                
       }
       BookInfo.ID= BookInfo.GetHashCode();//creates an id for the book
       
       var serializer = new XmlSerializer(typeof(Book));//serializes the information into an xml file
       string path = "/workspaces/C-sharp/Library/Books/ID";
       
       FileStream writer = new(path+BookInfo.ID.ToString(),FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write);
       serializer.Serialize(writer,BookInfo);
       writer.Close();
       break;
       case "sh"://this action searches trough the xml files to find the info about the book if any
       System.Console.Write("Find a book ");
       string? book = System.Console.ReadLine();//input the name of the book or its id
       DirectoryInfo dir = new("/workspaces/C-sharp/Library/Books");//takes the names of all files in the Book folder
       FileInfo[] dirInfo = dir.GetFiles();//formats the file names in an array
       Book results;
       bool contains = false;//it becomes true if a book is found
      
       XmlSerializer xml = new(typeof(Book));
       foreach(var showme in dirInfo)//it loops trough all files in the folder
                    {
                    FileStream reader = new(showme.ToString(),FileMode.Open,FileAccess.Read,FileShare.Read);//it read the content of a file
                    results=(Book) xml.Deserialize(reader);//then it deserializes it into the results variable of class Book
                    reader.Close();
                    if(results.Name.ToUpper().Contains(book.ToUpper())|| results.ID.ToString().Contains(book))//check if a book is found
                        {
                        System.Console.WriteLine($"Name: {results.Name}");
                        System.Console.WriteLine($"Author: {results.Author}");
                        System.Console.WriteLine($"Date of publishing: {results.Pulished}");
                        System.Console.WriteLine($"System ID: {results.ID}");
                        contains = true;
                        break;
                        }
                    }
                    if(!contains)
                    {
                    System.Console.WriteLine("Not Found");
                    }
       break;
        }
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

            public override int GetHashCode()//writes a custom id for every book
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
