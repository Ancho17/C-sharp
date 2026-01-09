using System.Text.Json;

namespace Serialization
{
class Realisation
    {
    static void Main()
        {
        string path = "/workspaces/C-sharp/Serialization/Info.json";
        Numbers one = new(){first=3,second=4,third=1};
        var options = new JsonSerializerOptions { WriteIndented = true };
        string info = JsonSerializer.Serialize(one,options);
        File.WriteAllText(path,info);
        string? info2 = File.ReadAllText(path);
        Test? two =  JsonSerializer.Deserialize<Test>(info2);
        System.Console.WriteLine(two.first);
        System.Console.WriteLine(two.second);
        System.Console.WriteLine(two.third);
        
        
        
  
        }
        public class Numbers
        {
        public int first{get;set;}
        public int second{get;set;}
        
        public int third{get;set;}
        }
        public class Test
        {
        public int first{get;set;}
        public int second{get;set;}
        
        public int third{get;set;}
        }
    }
}