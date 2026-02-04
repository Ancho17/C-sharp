
abstract class Entity
{
public string? Name {get;set;}
public int Health{get;set;}
public int Stats{get;set;}
public string StatusEf{get;set;}
public uint Timer{get;set;} 
public Entity(int health,string status)
{
Health = health;
StatusEf = status;
}

public virtual int QAbility(int _Health,int stats,ref string StatusEf){return 0;}
public virtual int WAbility(int _Health,int stats,ref string StatusEf){return 0;}
public virtual int EAbility(int _Health,int stats, ref string StatusEf){return 0;}
public virtual int RAbility(int _Health,int stats, ref string StatusEf){return 0;}




}

