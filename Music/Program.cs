namespace Music
{
    class Dance
    {
        static void Main()
        {
            using FileStream lisening = new ("/workspaces/C-sharp/Music/input.mp3",FileMode.OpenOrCreate,FileAccess.Read,FileShare.Read);
           
            var info = new FileInfo("/workspaces/C-sharp/Music/input.mp3");
            int counter;
            byte[] buffer = new byte[1];
            int c=0;
            long stlenght = info.Length-128;
            string information="";
            while((counter=lisening.Read(buffer,0,1))!=0)
            {
                
            if(c>=stlenght&&c<=stlenght+2)
                {
                    information += Display(buffer);
                }
                if(c==stlenght+3)
                {
                information+="\n";
                }
                if(c>=stlenght+3&&c<=stlenght+30) 
                {
                     information += Display(buffer);
                }
                if(c==stlenght+31)
                {
                information+="\n";
                }
                if(c>=stlenght+31&&c<=stlenght+61) 
                {
                     information += Display(buffer);
                }
                if(c==stlenght+62)
                {
                information+="\n";
                }
                if(c>=stlenght+62&&c<=stlenght+92) 
                {
                     information += Display(buffer);
                }
                if(c==stlenght+93)
                {
                information+="\n";
                }
                if(c>=stlenght+93&&c<=stlenght+96) 
                {
                     information += Display(buffer);
                }

                c++;
            }
            System.Console.WriteLine(information);
           
           
        }
        static string Display(byte[] a)
        {
            string result ="";
            if(a[0]!=0){
            result+=(char)a[0];
            }
            
            return result;
        }
    }
}
