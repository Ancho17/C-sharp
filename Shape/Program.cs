namespace ShapeShifter
{
class MaMen
{
    static void Main()
        {
        Square square = new(9,0);
        square.Area();
        Diamond diamond = new(4,6);
        diamond.Area();
        }
abstract class ShapeShifter
        {
        public double S{get;set;}
        public double A{get;set;}
        public double B{get;set;}
        public ShapeShifter(double a,double b)
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
        public Square(double a,double b):base(a,b)
            {
            
            }
            public override void Area()
            {
                S=A*A;
                System.Console.WriteLine($"The area of a square is {S}");
            }

        
        }  
    class Diamond : ShapeShifter
        {
        public Diamond(double a,double b):base(a,b){}
            public override void Area()
            {
                S=(A*B)/2;
                System.Console.WriteLine($"The area of diamond is {S}");
            }

        }  
        
    }
}
