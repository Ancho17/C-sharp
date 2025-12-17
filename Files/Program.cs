using System.IO;
using System.Text;
using System.Text.Unicode;
namespace Files
{
class Learn_File
    {
    static void Main()
        {
       string word =System.Console.ReadLine();
       using FileStream writter = new FileStream("/workspaces/C-sharp/Files/DesHello.txt",FileMode.Append,FileAccess.Write,FileShare.None);
       byte[] buffer = Encoding.UTF8.GetBytes(word);
       writter.Write(buffer,0,word.Length);

        }

      
    }
    
}
