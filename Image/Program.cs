namespace Image
{
class Picture
    {
    static void Main()
    {
        string path = "/workspaces/C-sharp/Image/blue-bmp-16-bit.bmp";
     using FileStream image = new(path,FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
     using FileStream cheker = new(path,FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
  
     int count;
     int size =1;
     
     byte[] buffer = new byte[size];
     int counter = 0;
    string Width ="";
    string Height="";
    char test1 = (char)cheker.ReadByte();
    char test2 = (char)cheker.ReadByte();
 
      if(test1=='B'&&test2=='M')
      {
     while((count=image.Read(buffer,0,size))!=0)
            {
              counter++;
              if(counter>=20&&counter<=22)
                {
                Width += buffer[0].ToString();
                }  
              if(counter>=24&&counter<=26)
                {
                Height += buffer[0].ToString();
                }  
            } 
            System.Console.WriteLine(Width+"x"+Height);
      }
      else
            {
                System.Console.WriteLine("Not a BMP file");
            }
            

      
     
        

    }
    }
}
