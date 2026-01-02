namespace Inverted
{
class Index
    {
        static void Main()
        {
        System.Console.Write("Search for word ");
        string? word = System.Console.ReadLine();
        string[] tokens = word.Split(" ");
        List<string> doc = ["Document1","Document2"];
        for(int j=0;j<tokens.Length;j++){
            System.Console.Write($"{tokens[j]} ->");
        for(int i=0;i<doc.Count;i++)
        {
        using StreamReader reader = new("/workspaces/C-sharp/InvertedIndex/"+doc[i]+".txt");
        string search = reader.ReadToEnd();
        if(search.Contains(tokens[j]))
            {
                if(i!=0)
                    {
                        System.Console.Write(",");
                    }
            System.Console.Write(doc[i]);
            }
       
        
        
        }
        System.Console.WriteLine("");
        }

        }
    }
}
