using System.Text.Json;

namespace Questions
{
class Ask
{
 static void Main()
        {
        Question one = new();
        All all = new();
        int amount =5;
        string path = "/workspaces/C-sharp/Questionnaire/Answers.json";
        all.AllAnswers = new char[amount];
        string[] ask = 
        {"What is your gender \n a:male b:female c:other ",
         "What is your age range \n a:<19 b:20-40 c:41+ ",
         "How often do u exercise \n a:i don't b:once or twice c:pretty often ",
         "Do u have health problems \n a:No b: pretty small ones c: pretty serious ones ",
         "How much do u sleep at night \n a:around 8h b:less than 8h c:more than 8h "

        };
        for(int i=0;i<amount;i++){
        all.AllAnswers[i]=AQuestion(ask[i],one.Answers);
        }
        string finish = JsonSerializer.Serialize(all);
        File.WriteAllText(path,finish);

        All reveal = JsonSerializer.Deserialize<All>(File.ReadAllText(path));
        System.Console.WriteLine("Your answers are: ");
        for(int i=0;i<reveal.AllAnswers.Length;i++)
            {
            System.Console.WriteLine($"To question {i+1} your answer is {reveal.AllAnswers[i]}");
            }
        

       

      
        
        }
    public class Question
        {
        private char answers;
        public char Answers{get {return answers;}
        set
                {
                if(value=='a'||value=='b'||value=='c')
                    {
                    answers = value;
                    
                    }
                    else 
                    {
                    answers = 'w';
                    }
                }
        }
        }
    public class All
        {
        public char[] AllAnswers{get;set;}
        }
    public static char AQuestion(string ask,char answer)
        {
        while(true)
            {
            System.Console.Write(ask);
            answer =System.Console.ReadLine()[0];
            if(answer!='a'&&answer!='b'&&answer!='c')
                {
                System.Console.WriteLine("Your answer must be a,b or c");
                }
            else
                {
                break;
                }
            }
        return answer;

        }
}
}
