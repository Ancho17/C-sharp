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
using HttpClient client = new();
string path = "https://www.hearstnetworks.com/";
string info = await CallMyRM(path,client);
System.Console.WriteLine(info);


}
public static async Task<string> CallMyRM(string path,HttpClient client)
{
HttpResponseMessage message = await client.GetAsync(path);
string data ="";
if(message.IsSuccessStatusCode)
            {
                data = await message.Content.ReadAsStringAsync();
            
            }
return data;
}

    }
    }
