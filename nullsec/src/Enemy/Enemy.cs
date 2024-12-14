using System ;
public abstract class Enemy
{
    public abstract string Faction { get ; }
    public abstract int MaxHealth { get ; set ; }
    public abstract int Health { get ; set ; }
    public abstract int AttackPower { get ; }
    public abstract void Attack (PlayerCharacter player);
}