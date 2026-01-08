using System.Text.Json;

namespace Serialization
{
class Realisation
    {
    static void Main()
        {
        Numbers one = new(){first=12,second = 45,third = 89};
        
        string path ="/workspaces/C-sharp/Serialization/Info.json";
        
       
       var option = new JsonSerializerOptions{ WriteIndented = true};
       byte[] serialize =JsonSerializer.SerializeToUtf8Bytes(one,option);
       
       File.WriteAllBytes(path,serialize);
       System.Console.WriteLine(serialize);
        }
        public class Numbers
        {
        public int first{get;set;}
        public int second{get;set;}
        
        public int third{get;set;}
        }
    }
}