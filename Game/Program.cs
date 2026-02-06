using Elements;
namespace MyGame
{

class TheGame
    {
  
   public static Action<string?,int,int>? Announce;
   public static Action<string?,string?,int,uint,int> Eff_Announce;
   
    static void Main()
        {
            int st=0;
            Hero hero = new(100+st*10,"None")
            {
                Name = "Hero",
                Stats = st,
                StatusEf="None",
                Timer = 0
            };
         Announce+=Call; 
         Eff_Announce+=CallEff;
         int dmg;
         int repdmgH=0;
         int repdmgE=0;
 
         var Eattack = new Random();  
        while(hero.Health>0)
            {
                Enemy enemy = new("Deamon",100+st*hero.Health/10,st,"None",0);
                System.Console.WriteLine($"{enemy.Name} attacks ");
                while (enemy.Health > 0)
                {
                if(hero.Timer!=0)
                    {
                    hero.Timer--;
                    if(repdmgH!=-1){
                    hero.Health-=repdmgH;
                    Eff_Announce.Invoke(hero.Name,hero.StatusEf,hero.Health,hero.Timer,repdmgH);
                    }
                else{
                    Eff_Announce.Invoke(hero.Name,hero.StatusEf,hero.Health,hero.Timer,0);
                }
                    if(hero.Timer==0)
                        {
                         hero.StatusEf =  "None"; 
                         repdmgH=0; 
                        }
                    }
                //enemy//
                   if(enemy.Timer!=0)
                    {
                    enemy.Timer--;
                    if(repdmgE!=-1){
                    enemy.Health-=repdmgE;
                    Eff_Announce.Invoke(enemy.Name,enemy.StatusEf,enemy.Health,enemy.Timer,repdmgE);
                    }
                else{
                    Eff_Announce.Invoke(enemy.Name,enemy.StatusEf,enemy.Health,enemy.Timer,0);
                }
                    if(enemy.Timer==0)
                        {
                         enemy.StatusEf =  "None"; 
                         repdmgE=0; 
                        }
                    } 
                    //enemy//
                if(hero.StatusEf!="None"&&hero.Timer==0)
                    {
                    
                    uint timer=0;
                    hero.StatusEf = StsEff.Effects(hero.StatusEf,ref timer, ref repdmgH);
                    hero.Timer=timer;
                  
                     if(repdmgH!=-1){
                    hero.Health-=repdmgH;
                    
                    Eff_Announce.Invoke(hero.Name,hero.StatusEf,hero.Health,hero.Timer,repdmgH);
                     }
                        else
                        {
                           Eff_Announce.Invoke(hero.Name,hero.StatusEf,hero.Health,hero.Timer,0);  
                        }
                    }
                //enemy//
                if(enemy.StatusEf!="None"&&enemy.Timer==0&&enemy.StatusEf!="Transform")
                    {
                    
                    uint timer=0;
                    enemy.StatusEf = StsEff.Effects(enemy.StatusEf,ref timer, ref repdmgE);
                    enemy.Timer=timer;
                  
                     if(repdmgE!=-1){
                    enemy.Health-=repdmgE;
                    
                    Eff_Announce.Invoke(enemy.Name,enemy.StatusEf,enemy.Health,enemy.Timer,repdmgE);
                     }
                        else
                        {
                           Eff_Announce.Invoke(enemy.Name,enemy.StatusEf,enemy.Health,enemy.Timer,0);  
                        }
                    }
                 //enemy//
                 
                if(hero.Health<=0) break;
                System.Console.WriteLine("-------------------------");
                System.Console.Write("Chose atack between q and r ");
                string? attack = Console.ReadLine();
                attack = attack?.ToUpper();
                if(repdmgH==-1){attack = "Stoped";}
                string hstatus="";
                string estatus="";
                 switch (attack)
                {
                  case "Q": dmg=hero.QAbility(enemy.Health,hero.Stats,ref estatus);if(estatus!=""){enemy.StatusEf = estatus;} enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  case "W": dmg=hero.WAbility(enemy.Health,hero.Stats,ref estatus);if(estatus!=""){enemy.StatusEf = estatus;}enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  case "E": int ur_Health=hero.EAbility(hero.Health,hero.Stats,ref estatus);if(estatus!=""){enemy.StatusEf = estatus;}Console.WriteLine($"You healed for {ur_Health - hero.Health} your health is {ur_Health}\n"); hero.Health = ur_Health;  break;
                  case "R": dmg=hero.RAbility(enemy.Health,hero.Stats,ref estatus);if(estatus!=""){enemy.StatusEf = estatus;} enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  case "Stoped": System.Console.WriteLine("Can't Move!");break;
                  default: dmg = 10; enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                    
                }
                if(enemy.StatusEf != "Transform"){
                if(enemy.StatusEf != "freeze" ){
                switch (Eattack.Next(-1,5))
                    {
                    case 1:dmg=enemy.QAbility(hero.Health,enemy.Stats,ref hstatus);if(hstatus!=""){hero.StatusEf = hstatus;}hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 2:dmg=enemy.WAbility(hero.Health,enemy.Stats,ref hstatus);if(hstatus!=""){hero.StatusEf = hstatus;}hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 3:dmg=enemy.EAbility(hero.Health,enemy.Stats,ref hstatus);if(hstatus!=""){hero.StatusEf = hstatus;} hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 4:dmg=enemy.RAbility(hero.Health,enemy.Stats,ref estatus);Console.WriteLine("TRANSFORMATION"); if(estatus!=""){enemy.Timer=2;enemy.StatusEf = estatus;repdmgE=5;} enemy.Health+=20;hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 0:dmg= 10; hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    }
                }
                }
                    else
                    {
                     dmg = 50 +st;
                     hero.Health-=DMG(hero.Name,hero.Health,dmg); 
                    
                    }
                if(hero.Health<=0) break;
                }
                hero.Stats+=10;
                st+=10;
                if (enemy.Health <= 0)
                {
                  System.Console.WriteLine($"{enemy.Name} was defeated ");  
                }
            }
            
        

    
        }
    
   
  public static int DMG(string? name,int health,int dmg)
        {
        
        Announce.Invoke(name,health - dmg,dmg);
        return health - dmg;
        }
    public  static void Call(string? entity,int health,int dmg)
        {
        System.Console.WriteLine($"{entity} took {dmg} current health:{health}");
        System.Console.WriteLine("");
        }
    public static void CallEff(string? entity,string? eff,int health,uint time,int dmg)
        {
        System.Console.WriteLine($"{eff} was activated {entity} took {dmg}  ");
        System.Console.WriteLine($"time left {time} turns");
        System.Console.WriteLine($"Current health {health}");
        }
  class Hero : Entity
    {
    public Hero(int health,string status ): base(health,status)
        {
        Health = health; 
        StatusEf=status;
        }
    public override int QAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        var attack = new Random();
        int att = attack.Next(0+ stats,90+ stats) ;

        return att;
        }
        public override int WAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        if(stats>=10)
                {
                StatusEf="freeze";
                }
        return 20 + stats;
        }   
        public override int EAbility(int YourHealth,int stats, ref string StatusEf)
        {
        return  YourHealth+10+stats;
        }   
        public override int RAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        int num = EnemyHealth/10;
        int dmg=0;
        for(int i=0;i<num;i++)
                {
                  dmg += 5;  
                }
        return dmg + stats;
        }      
    }
      class Enemy : Entity
    {
    
    public Enemy(string name,int health,int stats,string status,uint timer): base(health,status)
        {
        Name = name;
        Health = health; 
        Stats = stats;
        StatusEf=status;
        Timer = timer;
        }
    public override int QAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        int dmg =10+stats;
        dmg +=EnemyHealth/5;
        return dmg;
        }
        public override int WAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        StatusEf = "ignite";
        return 10;
        }   
        public override int EAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
        StatusEf = "freeze";
        return 10;
        }   
        public override int RAbility(int EnemyHealth,int stats,ref string StatusEf)
        {
             StatusEf="Transform";
        return 10;
        }      
    }
}
}