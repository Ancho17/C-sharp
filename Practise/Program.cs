namespace Practise
{
class Base
    {
        static void Main()
        {
            Two dve = new();
            Three tri = new();
          One[] numbers = [
            dve,tri];
            foreach( One number in numbers)
            {
                number.Hy();
            }

            


        }
    }
 
 public abstract class One
    {
    public virtual void Hy()
        {
        System.Console.WriteLine("Hello One");
        }
    }
    public class Two:One
    {
        public override void Hy()
        {
           System.Console.WriteLine("Hello Two");
        }
    }
    public class Three:Two
    {
        public sealed override void Hy()
        {
            System.Console.WriteLine("Hello Three");
        }
    }
   
 
}
