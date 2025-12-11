using System.Threading.Tasks.Dataflow;

namespace Practise
{
class Base
    {
        static void Main()
        {
            System.Console.Write("Number ");
           int number = Int32.Parse(System.Console.ReadLine());
           System.Console.WriteLine(Fibonacci(number,0,1,0));
        }
     static int Fibonacci (int times,int a,int b,int result)
        {
            
          int temp;
          if(times!=1)
            {
                result = a+b;
            temp =b;
            b=a+b;
            a=temp;
            result = Fibonacci(times-1,a,b,result);

            }
            
            return result;
            
        }
      
  
           

    }
   
    
     
    
   
    

}
 
 

