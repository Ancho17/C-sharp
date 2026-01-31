namespace MyGame
{

class TheGame
    {
  
   public static Action<string?,int,int>? Announce;
   
    static void Main()
        {
            int st=0;
            Hero hero = new(100+st*10)
            {
                Name = "Hero",
                Stats = st
            };
         Announce+=Call; 
         int dmg;
 
         var Eattack = new Random();  
        while(hero.Health>0)
            {
                Enemy enemy = new("Deamon",100+st*hero.Health/10,st);
                System.Console.WriteLine($"{enemy.Name} attacks ");
                while (enemy.Health > 0)
                {
                System.Console.Write("Chose atack between q and r ");
                string? attack = Console.ReadLine();
                attack = attack?.ToUpper();
                 switch (attack)
                {
                  case "Q": dmg=hero.QAbility(enemy.Health,hero.Stats); enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  case "W": dmg=hero.WAbility(enemy.Health,hero.Stats); enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  case "E": int ur_Health=hero.EAbility(hero.Health,hero.Stats);Console.WriteLine($"You healed for {ur_Health - hero.Health} your health is {ur_Health}\n"); hero.Health = ur_Health;  break;
                  case "R": dmg=hero.RAbility(enemy.Health,hero.Stats); enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                  default: dmg = 10; enemy.Health=DMG(enemy.Name,enemy.Health,dmg); break;
                    
                }
                switch (Eattack.Next(0,4))
                    {
                    case 1:dmg=enemy.QAbility(hero.Health,enemy.Stats); hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 2:dmg=enemy.WAbility(hero.Health,enemy.Stats); hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 3:dmg=enemy.EAbility(hero.Health,enemy.Stats); hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 4:dmg=enemy.RAbility(hero.Health,enemy.Stats); hero.Health=DMG(hero.Name,hero.Health,dmg); break;
                    case 0:dmg= 10; hero.Health=DMG(hero.Name,hero.Health,dmg); break;
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
  class Hero : Entity
    {
    public Hero(int health ): base(health)
        {
        Health = health; 
        }
    public override int QAbility(int EnemyHealth,int stats)
        {
        var attack = new Random();
        int att = attack.Next(0+ stats,90+ stats) ;

        return att;
        }
        public override int WAbility(int EnemyHealth,int stats)
        {
        return 20 + stats;
        }   
        public override int EAbility(int YourHealth,int stats)
        {
        return  YourHealth+10+stats;
        }   
        public override int RAbility(int EnemyHealth,int stats)
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
    
    public Enemy(string name,int health,int stats ): base(health)
        {
        Name = name;
        Health = health; 
        Stats = stats;
        }
    public override int QAbility(int EnemyHealth,int stats)
        {
        int dmg =10;
        dmg +=EnemyHealth/50-20;
        return 30;
        }
        public override int WAbility(int EnemyHealth,int stats)
        {
        return 10;
        }   
        public override int EAbility(int EnemyHealth,int stats)
        {
        return 10;
        }   
        public override int RAbility(int EnemyHealth,int stats)
        {
        return 10;
        }      
    }
}
}