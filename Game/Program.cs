namespace MyGame
{

class TheGame
    {
  
   
    static void Main()
        {
     
        System.Console.Write("Give me name: ");
        Hero hero = new(100);
        hero.Name = Console.ReadLine();
        Enemy enemy = new("Deamon",100);
        double dmg= enemy.QAbility(hero.Health);
        System.Console.WriteLine($"{enemy.Name} dealt {dmg}");
         
        hero.Health = DMG(hero.Health,dmg);
        System.Console.WriteLine($"{hero.Name}'s health is {hero.Health}");
        
        

    
        }
    
   
  public static double DMG(double health,double dmg)
        {
        return health - dmg;
        }
  class Hero : Entity
    {
    public Hero(double health ): base(health)
        {
        Health = health; 
        }
    public override double QAbility(double EnemyHealth)
        {
        return EnemyHealth/3;
        }
        public override double WAbility(double EnemyHealth)
        {
        return 10;
        }   
        public override double EAbility(double EnemyHealth)
        {
        return  10;
        }   
        public override double RAbility(double EnemyHealth)
        {
        return 10;
        }      
    }
      class Enemy : Entity
    {
    
    public Enemy(string name,double health ): base(health)
        {
        Name = name;
        Health = health; 
        }
    public override double QAbility(double EnemyHealth)
        {
        return EnemyHealth - 10;
        }
        public override double WAbility(double EnemyHealth)
        {
        return 10;
        }   
        public override double EAbility(double EnemyHealth)
        {
        return 10;
        }   
        public override double RAbility(double EnemyHealth)
        {
        return 10;
        }      
    }
}
}