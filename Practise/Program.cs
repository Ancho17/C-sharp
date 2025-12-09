using System.Threading.Tasks.Dataflow;

namespace Practise
{
class Base
    {
        static void Main()
        {
            System.Console.Write("Symbol:");
             string? symbol = System.Console.ReadLine();
            System.Console.Write("Height and Width: ");
            int height_width = Int32.Parse(System.Console.ReadLine());
            

             for(int j=0;j<height_width;j++)
             {
             for(int i =0; i<height_width;i++)
            {
               if(j<1||j>height_width-2){
                
            System.Console.Write(symbol);
               }
                    else
                    {
                        if(i>0&&i<height_width-1)
                        {
                            System.Console.Write(" ");
                        }
                        else
                        {
                            System.Console.Write(symbol);
                            
                        }
                    }
               
            }
            System.Console.WriteLine("");
             }

        
     
       
        
        
        }
  
           

    }
    
    
    
   
    

  
   
    
   
    

}
 
 

