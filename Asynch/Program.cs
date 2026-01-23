using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;
namespace Synchro
{
class Synchronizing
    {
static async Task Main(string[] args)
{
List<Task> mylist = [];
 mylist.Add( Doing());
 mylist.Add( Did());
 mylist.Add( Does());
 
await Task.WhenAll(mylist);

 System.Console.WriteLine("Finish");
 
 
 


}
static async Task Doing()
        {
        string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
        info +=",1";
        System.Console.WriteLine(info);
        
        }
         static async Task  Did()
         {
         string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
         await Task.Delay(1000);
          info +=",2";
         System.Console.WriteLine(info);
        }
         static async Task Does()
        {
         string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
          info +=",3";
         System.Console.WriteLine(info);
      }


    }
    }
