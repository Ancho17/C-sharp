using System.Reflection.Metadata;

namespace EventOrganaizer
{
class Eventer
    {
 public static EventHandler? See;
    static void Main()
        {

    Store store = new(){Name_Product="RAM",Price = 30};
    Production production = new(){Amount = 0};
    store.Warning += Call;
    store.Price =350;
    store.Warning -= Call;
    store.Price =450;
    See +=NoAmount;
    See += (o,e)=>{System.Console.WriteLine("You don't have anymore");};
    production.OnNomore(production.Amount);
    
    
    
        }

   public class Store
        {
         private event Action<string>? warning;
         public event Action<string>? Warning
         {add{warning +=value;} remove{warning -=value;}}
        
        public string? Name_Product {get;set;}
        private int price;
        public int Price{get{return price; }
                set
                {
                 if(price>20)
                    {
                    price = value;
                   warning?.Invoke(Name_Product);
                    
                    } 
                    else
                    {
                    price = value;
                    }  
                }
            }
        

        
        }
    static void Call(string product)
        {
        System.Console.WriteLine($"{product} is too expensive.");
        }
    public class Production
        {
        public int Amount{get;set;}
        public virtual void OnNomore(int amount)
            {
            if(amount==0)
            See?.Invoke(this,EventArgs.Empty);
            }
        }
    public static void NoAmount(object? o,EventArgs e)
        {
        System.Console.WriteLine("No more");
        }
     
   
  

 
    }
    
}