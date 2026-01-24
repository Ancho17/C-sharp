namespace MainSearcher
{
class MyProgram
{
static async Task Main()
        {
       Console.Write("Look up a word: ");
       string? word = System.Console.ReadLine();
      
       DirectoryInfo dir = new("/workspaces/C-sharp/DeepSearch/MyFiles");//takes the names of all files in the MyFiles folder
       FileInfo[] dirInfo = dir.GetFiles();//stores the names
       int size = dirInfo.Length/2;
       int fs = 0;
       
       if(size%2!=0&&dirInfo.Length!=2)
        { 
        size ++;
        }
      

       for(int i=0;i<size;i++)
                        {
                        try{
                        string location = dirInfo[i + fs].ToString();
                        string[] Path1 = await GetWords(location);
                        fs++;
                        Look(Path1,word,location);
                        location = dirInfo[i + fs].ToString();
                        string[] Path2 = await GetWords(location);
                        Look(Path2,word,location);
                        
                       
                        }
                        catch(IndexOutOfRangeException)
                                {
                                break;
                                }
                        }
        

     
        }
static async Task<string[]> GetWords(string path)
                {
                 string get = await File.ReadAllTextAsync(path);
                 string[] change = get.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                 char[] remove =['.',',','(',')','[',']','\\','/'];
                 for(int i = 0; i < change.Length; i++)
                        {
                        for(int j=0;j<remove.Length;j++)
                                {
                                if(change[i].Contains(remove[j]))
                                        {
                                        int index = change[i].IndexOf(remove[j]);
                                        change[i] = change[i].Remove(index);
                                        }
                                       
                                }
                        }
                 return change;      
                }
static void Look(string[] paths,string word,string location )
                {
                word=word.ToUpper();
                int count =0;
                for(int i = 0; i < paths.Length; i++)
                        {
                        if(word==paths[i].ToUpper()&&paths[i]!="")
                                {
                                count ++;
                                }
                        }
                System.Console.WriteLine($"In file location {location}");
                System.Console.WriteLine($"We found the word {word.ToLower()} : {count} times");
                }
   
}
}