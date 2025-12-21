using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace Second
{
class AnotherOne
    {
    static int Main()
        {
            System.Console.Write("Would you like to make open a note app Y/N: ");
         string ? Starter = System.Console.ReadLine();
         if(Starter.ToUpper()=="Y")
            {
            System.Console.WriteLine("What would you like to do ");
            System.Console.WriteLine("wn - write note ,vn - view note,dn delete note");
             System.Console.Write("Choise: ");
             string? task =System.Console.ReadLine();
             switch(task)
                {
                case "wn":
             string? path = Read();
             FileStream writer = new(path,FileMode.Append,FileAccess.Write,FileShare.None);
             System.Console.Write("Your text: ");
             string? text =System.Console.ReadLine();
             byte[] buffer = Encoding.UTF8.GetBytes(text);
             writer.Write(buffer,0,buffer.Length);
             writer.Close();
             break;
             case "vn":
             string? path2 = Read();
             try{
             StreamReader reader = new(path2);
             string? text2 = reader.ReadToEnd();
             reader.Close();
             System.Console.WriteLine("Note ");
             System.Console.WriteLine(text2);
             System.Console.WriteLine("End of note");
             }
             catch(FileNotFoundException)
                        {
                        System.Console.WriteLine("File not found");
                        }
             break;
             case "dn":
             string? path3 = Read();
             try{
             File.Delete(path3);
             }
             catch(FileNotFoundException)
                        {
                        System.Console.WriteLine("File not found");
                        }
             break;

                }

              
            }
            else if(Starter.ToUpper()=="N")
            {
            return 0;    
            }


            return 0;
        }
        static string Read()
        {
            System.Console.Write("Name of note: ");
             string? name =System.Console.ReadLine();
             string? path = "/workspaces/C-sharp/File2/YourNotes/" + name;
             return path;
        }

    }
}
