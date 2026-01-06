namespace HappyNumbers
{
class HappyHappy
    {
    static void Main()
        {
            System.Console.Write("Chose a number: ");
           int number = Int32.Parse(System.Console.ReadLine());
           int part1;
           int part2;
           int count =0;
           while(number!=1)
            {
                if(count>10)
                {
                break;
                }
                part1 = number%10;
                part2 = number/10;
                number=part1*part1 + part2*part2;
                count ++;


            }
            if(number==1)
            System.Console.WriteLine("Happy Happy Happy");
        }
    }
}