namespace EnumLearn
{
    class Enums
    {
    static void Main()
        {
     
         List<string> mylist = ["chery","strwaberry","apple"];
        
         var count = Enum.GetNames(typeof(Fruit)).Length;
         for(int i=0;i<mylist.Count;i++)
            {
            for(int j=0;j<count;j++)
                {
                Fruit mainIN = (Fruit)j;
                string fruit = mainIN.ToString();
                if(mylist[i]==fruit)
                    {
                    System.Console.WriteLine(fruit+" is in the List");
                    }
                }
            }
        }
 
   
  
    }
            enum Fruit
    {
        apple,
        orange,
        grape,
        strwaberry,
        chery
    }
   
    
}
