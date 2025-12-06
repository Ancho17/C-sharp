

using System.Collections.ObjectModel;

namespace Practise
{
class Base
    {
        static void Main()
        {
            List<uint> colection = [];
        Fibonachi count = new(1,2);
        count.Calc(colection);
       IEnumerable<uint> order =
       from colect in colection
       where colect % 2==0
       orderby colect descending
       select colect;
       foreach(var colect in order)
            {
                System.Console.Write("{0},",colect);
            }
            System.Console.WriteLine(" ");

        

           

        }
    }
 public class Fibonachi
    {
        public uint a{get;set;}
        public uint b{get;set;}
        
        public Fibonachi(uint a,uint b)
        {
        this.a = a;
        this.b = b;
        }

        public List<uint> Calc( List<uint> colection)
        {
          uint temp=0;
         colection.Add(a);
         colection.Add(b);
          for(int i=0;i<30;i++)
            {
            temp =b;
            b=a+temp;
            a= temp;
            colection.Add(b);
            } 
           return colection; 
        }
    }

 
}
