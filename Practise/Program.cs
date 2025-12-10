using System.Threading.Tasks.Dataflow;

namespace Practise
{
class Base
    {
        static void Main()
        {
           
            Dictionary<string,int> inventory = [];
            inventory.Add("apple",3);
            inventory.Add("orange",5);
            inventory.Add("banana",2);
            foreach(var item in inventory)
            {
            System.Console.WriteLine($"{item.Key}:{item.Value}");
            }
           
         
            
            
            
            
            
           
        
        
        }
  
           

    }
    
     
    
   
    

}
 
 

