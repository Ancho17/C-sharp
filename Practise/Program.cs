using System.Threading.Tasks.Dataflow;

namespace Practise
{
class Base
    {
        static void Main()
        {
        System.Console.Write("Word ");
         string? word = Console.ReadLine();
         System.Console.WriteLine(Palidrome(word,word.Length,0,false));

         
        

        }
         static bool Palidrome(string word,int lenght,int start,bool status)
        {
         if(start == lenght-1)
            {
                return status;
            }
            else
            {
                if(word[lenght-1]==word[start])
                {
                status = true;
                }
                else
                {
                return false;
                }
            return status =Palidrome(word,lenght-1,start+1,status);
            }
        }

    }
   
    
     
    
   
    

}
 
 

