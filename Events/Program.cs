using System.Reflection.Metadata;

namespace EventOrganaizer
{
class Eventer
    {
  
    static void Main()
        {
     Pet Tobby = new();
     Wellcomer Tom = new();
     Tom.Notify += Tobby.GetHome;
     System.Console.Write("Name of pet ");
     string? name = System.Console.ReadLine();
     Tom.Wellcome(name);

     
    
        }
    public class Pet
        {
        public void GetHome(string ur_pet)
            {
            System.Console.WriteLine($"{ur_pet} is home");
            }
        }
    public class Wellcomer
        {
        public event Action<string>? Notify;
        public void Wellcome(string pet)
            {
            if(pet!=""){
            Notify?.Invoke(pet);
            System.Console.WriteLine($"Welcome Home {pet}");
            }
            }
        }

 
    }
}