using System.IO;
using System.Text;
namespace Files
{
class Learn_File
    {
    static void Main()
        {
        StreamWriter writer = new StreamWriter("/workspaces/C-sharp/Files/Hello.txt",false);
        writer.Write("Hello World");
        writer.Close();


        }
    }
}
