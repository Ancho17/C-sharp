using System.IO;
using System.Text;
using System.Text.Unicode;
namespace Files
{
class Learn_File
    {
    static void Main()
        {
       FileStream reader =new FileStream("/workspaces/C-sharp/Files/Hello.txt",FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
       int size =1;
       byte[] buffer = new byte[size];
       bool checker = false;
       int count;
       int countText=0;
       int dotcount = 0;
       string text = "";
       string? temp ;
       
       while((count=reader.Read(buffer,0,size))!=0)
            {
                temp = Encoding.UTF8.GetString(buffer,0,size); 
            text += temp;
            if(temp==".")
                {
                    dotcount++;
                }
            if(checker==true&&!temp.Contains('\n'))
                {
                checker = false;
                }
                
           
                else{
            if(temp.Contains(' '))
                {
                countText++;
                checker=true;
                }
                 else if(temp.Contains('.') )
                {
                countText++;
                checker=true;
                
                }
                }
                
            }
            System.Console.WriteLine(countText);
            
            
        }
        

      
    }
    
}
