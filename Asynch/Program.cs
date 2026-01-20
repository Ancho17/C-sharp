using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace Synchro
{
class Synchronizing
    {
static async Task Main(string[] args)
{
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
await Did();
await Does();
stopWatch.Stop();
 TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);


}
public static async Task Does()
        {
        
        
        string text = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/example.txt");
        
        }
        
public static async Task Did()
        {
        
        string info = await File.ReadAllTextAsync("/workspaces/C-sharp/Asynch/exapmle2.txt");
         
        }

    }

}
