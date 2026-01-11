namespace Image
{
class Picture
    {
    static void Main()
    {
        string path = "/workspaces/C-sharp/Image/blue-bmp-16-bit.bmp";
     using FileStream image = new(path,FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
     using FileStream end = new("/workspaces/C-sharp/Image/Finish.bmp",FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write);
     
  
     int count;
     int size =1;
     
     byte[] buffer = new byte[size];
     int counter = 0;

     while((count=image.Read(buffer,0,size))!=0)
            {
              counter++;
              if(counter>=58)
        {
          buffer[0]+=50;
          
          
          end.Write(buffer,0,size);
        }
        else
        {
         end.Write(buffer,0,size); 
        }
            
            } 

        //  if(counter>=20&&counter<=22)
        //         {
        //         Width += buffer[0].ToString();
        //         }  
        //       if(counter>=24&&counter<=26)
        //         {
        //         Height += buffer[0].ToString();
        //         }  
    
            

      
     
        

    }
    }
}
