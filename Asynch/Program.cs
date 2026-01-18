using System.Threading;
using System.Threading.Tasks;
namespace Synchro
{
class Synchronizing
    {
static async Task Main(string[] args)
{
await Did();
await Does();

}
public static async Task Does()
        {
        
        string result = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/example.txt");
        System.Console.WriteLine(result);
        }
        
        public static async Task Did()
        {
        await Task.Delay(2000);
        string finish = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/exapmle2.txt");
        System.Console.WriteLine(finish);
        
        }

    }

}
