namespace FlowerShop
{
class MyShop
    {
    static void Main()
        {
         Flower Lily = new(){Name="Lily",Price = 2.30,Amount=0};
         Flower Rose = new(){Name="Rose",Price = 3.60,Amount=0};
         Bouquet LR = new(){
         Flowers = [
             new(){Name="Lily",Price = 2.30,Amount=3},
             new(){Name="Rose",Price = 3.60,Amount=2}

         ]
         };
         LR.PrizeEvaluation();

         
         
        }
    }
    public class Flower
    {
    public  required string Name {get;init;}
    public required double Price {get;set;}
    public int Amount{get;set;}

    public void Buy()
        {
        System.Console.Write("How much to buy ");
        int quantity =Int32.Parse(System.Console.ReadLine());
        Amount += quantity;
        }
    }
    public class Bouquet
    {
public List<Flower> Flowers {get;set;} = [];
public void PrizeEvaluation()
        {
        double Fprice =0.0;
        foreach(var price in Flowers)
            {
                Fprice += price.Price;
            }
            System.Console.WriteLine($"The bouquets price is {Fprice}");
        }
    }
}
