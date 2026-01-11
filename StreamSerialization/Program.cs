using System.Text;
using System.Text.Json;

namespace SendMeSomeJsonSon
{
class SendTheJson
    {
    static void Main()
        {
        Dog Toby = new("Toby",1);
        Toby.Foods = [];
        Toby.Foods.Add("almond");
        Toby.Foods.Add("dog food");
        Toby.Foods.Add("paper");

        string path = "/workspaces/C-sharp/StreamSerialization/Info.json";
        
        var option = new JsonSerializerOptions { WriteIndented = true };
        string info = JsonSerializer.Serialize(Toby,option);
        
        using FileStream writter = new(path,FileMode.Open,FileAccess.Write,FileShare.Write);
        byte[] coverter = Encoding.UTF8.GetBytes(info);
        byte[] buffer = new byte[1];
        for(int i=0;i<coverter.Length;i++)
            {
                buffer[0]=coverter[i];
                writter.Write(buffer,0,buffer.Length);
            }
      
     
    
        }
    public class Dog
        {
        public string Name{get;set;}
        public int Age{get;set;}

        public List<string>? Foods{get;set;}
        public Dog(string name,int age)
            {
            Name=name;
            Age=age;
            }

        }
    }
}