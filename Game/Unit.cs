
abstract class Entity
{
public string? Name {get;set;}
public double Health{get;set;}
public Entity(double health)
{
Health = health;
}

public virtual double QAbility(double EnemyHealth){return 0;}
public virtual double WAbility(double EnemyHealth){return 0;}
public virtual double EAbility(double EnemyHealth){return 0;}
public virtual double RAbility(double EnemyHealth){return 0;}




}

