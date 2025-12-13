namespace Word_count
{
    class Begin
    {
    static void Main()
        {
            System.Console.Write("Type here: ");
            string word = System.Console.ReadLine();
            string word2 = word;
            int count = 0;
            int positon;
            if(word=="")
            {
            positon = 0;
            }
            else
            {
            positon = 1;
            }
            int position2;
            
            while(positon>0)
            {
            positon = word.IndexOf(" ");
            position2 = positon+1;
            count++;
            word=word.Substring(position2,word.Length-positon-1);
            }
            string[] words = word2.Split(' ');
            
            
            
            
            System.Console.WriteLine("The number of word is "+count);
            foreach(var s in words)
            {
                System.Console.WriteLine($"The lenght of {s} is {s.Length}");
            }
        }
    }
}