using System.IO;
using System.Text;
using System.Text.Unicode;
namespace Files
{
class Learn_File
    {
    static void Main()
        {
       StreamReader reader =new("/workspaces/C-sharp/Files/Hello.txt");
       StringBuilder text = new();
       string read = reader.ReadLine();
       text.Append(read);
       
       for(int i=0;i<text.Length;i++)
            {
                int s = (int)text[i]+3;
                char ch = Convert.ToChar(s);
                
                text.Replace(text[i],ch);
            }
       reader.Close();
       StreamWriter writer = new("/workspaces/C-sharp/Files/Hello.txt");
       writer.Write(text.ToString(),false);
       writer.Close();


        }
    }
}
