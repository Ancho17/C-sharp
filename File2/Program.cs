using System.Net.WebSockets;
using System.Text;

namespace Second
{
class AnotherOne
    {
    static void Main()
        {
         using FileStream reader = new("/workspaces/C-sharp/File2/Start.txt",FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
         using StreamWriter writer = new("/workspaces/C-sharp/File2/Complete.inv");
         int size=1;
         string text = "";
         
         char[] ftext;
         byte[] buffer = new byte[size];
         
             
         while(reader.Read(buffer,0,size)!=0)
            {        
              text +=Encoding.UTF8.GetString(buffer,0,size);
            }
            ftext =text.ToCharArray();
            Array.Reverse(ftext);
            text="";
            foreach(var chr in ftext)
            {
                text+=chr;  
            }
           writer.Write(text);




        }

    }
}
