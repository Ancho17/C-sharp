
abstract class Entity
{
public string? Name {get;set;}
public int Health{get;set;}
public int Stats{get;set;}
public Entity(int health)
{
Health = health;
}

public virtual int QAbility(int _Health,int stats){return 0;}
public virtual int WAbility(int _Health,int stats){return 0;}
public virtual int EAbility(int _Health,int stats){return 0;}
public virtual int RAbility(int _Health,int stats){return 0;}




}

