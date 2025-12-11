using System.Threading.Tasks.Dataflow;

namespace Practise
{
class Base
    {
        static void Main()
        {
            System.Console.Write("Number ");
           int number = Int32.Parse(System.Console.ReadLine());
           System.Console.Write("Times ");
           int times = Int32.Parse(System.Console.ReadLine());
           recursion(number,times,number);
           
        
        }
        static void recursion(int number,int times ,int based)
        {
            
        if(times!=1)
            {
             
              number *=based;
                recursion(number, times-1, based);
            }
            if(times==1){
            System.Console.WriteLine(number);
            }
        }
      
  
           

    }
   
    
     
    
   
    

}
 
 

