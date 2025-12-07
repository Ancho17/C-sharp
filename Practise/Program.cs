

using System.Collections.ObjectModel;
using System.Globalization;

namespace Practise
{
class Base
    {
        static void Main(string[] argc)
        {
            try{
           BankAcount Jhon = new()
           {
            Name = "Jhon",
            Amount = 1000
           };
           Jhon.MoneyHandle(argc[0]);
            }
            catch(IndexOutOfRangeException)
            {
            System.Console.WriteLine("Please add wd for withdraw or d for deposit after dotnet run");
            }
        

           

        }
    

    }
 public class BankAcount
    {
    public string? Name{get;set;}
    public int Amount{get;set;}
    public void MoneyHandle(string arg)
        {
            int get =0;
            int put=0;
            switch(arg){
                case "wd":
         try{
            System.Console.Write("The amount you would like to withdraw: ");   
         get= Int32.Parse(Console.ReadLine());
         }
         catch(FormatException)
            {
            System.Console.WriteLine("Please input valid numeric characters");
            }
            catch(ArgumentOutOfRangeException ex)
            {
            System.Console.WriteLine(ex.Message);
            }
            if(get>Amount)
            {
            throw new ArgumentOutOfRangeException("Not enough money to withdraw");
            }
        Amount -= get;
        break;
        case "d":
            
            try{
                System.Console.Write("The amount you would like to deposit: ");
         put= Int32.Parse(Console.ReadLine());
            }
             catch(FormatException ex)
            {
            System.Console.WriteLine("Please input valid numeric characters");
            }
        Amount +=put;
            break;
        }
        Console.WriteLine($"Current amount of money in {Name}'s bank account is {Amount} ");
        }
    }
 
}
