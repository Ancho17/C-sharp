namespace ShapeShifter
{
class MaMen
{
    static void Main()
        {
        Square square = new(9,2);
        square.Area();
        }
abstract class ShapeShifter
        {
        public int S{get;set;}
        public int A{get;set;}
        public int B{get;set;}
        public ShapeShifter(int a,int b)
            {
            
            A=a;
            B=b;
            }
        public virtual void Area()
            {
            S=A*B;
            }
        }
    class Square : ShapeShifter
        {
        public Square(int a,int b):base(a,b)
            {
            
            }
            public override void Area()
            {
                S=A*A;
                System.Console.WriteLine($"The are of a square is {S}");
            }

        
        }    
}
}
