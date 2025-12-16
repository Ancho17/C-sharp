using System.IO;
using System.Text;
using System.Text.Unicode;
namespace Files
{
class Learn_File
    {
    static void Main()
        {
            using FileStream fs = new("/workspaces/C-sharp/Files/DesHello.txt",FileMode.OpenOrCreate,FileAccess.Write,FileShare.None);
            
            var text = "Hello World";
            byte[] buffer = Encoding.UTF8.GetBytes(text);
             fs.Write(buffer,0,text.Length);

            fs.Close();
            using FileStream fd = new("/workspaces/C-sharp/Files/DesHello.txt",FileMode.Open,FileAccess.Read,FileShare.Read);
            byte[] bucket = new byte[text.Length];
            int count;

             
             while((count=fd.Read(bucket,0,text.Length))!=0){

            System.Console.WriteLine(Encoding.UTF8.GetString(bucket,0,text.Length));
             }
            fd.Close();
            








        }

      
    }
}
