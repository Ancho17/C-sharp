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
 mylist.Add(Doing());
 mylist.Add(Did());
 mylist.Add(Does());

 var finale = Task.WhenAny(mylist);
 System.Console.WriteLine(finale);


}
static async Task<string> Doing()
        {
        string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
       return info;
        }
         static async Task<string>  Did()
         {
         string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
         return info;
        }
         static async Task<string>  Does()
        {
         string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/numbers.txt");
         return info;
      }


    }
    }
