namespace Engine.Models;

public class Weapon : GameItem
{
    public int MiniumumDamage { get; set; }
    public int MaximumDamage { get; set; }
    public Weapon(
        int itemTypeId, 
        string name, 
        int price,
        int miniumumDamage, 
        int maximumDamage) : 
        base(
            itemTypeId, 
            name, 
            price)
    {
        MiniumumDamage = miniumumDamage;
        MaximumDamage = maximumDamage;
    }

    public new Weapon Clone()
    {
        return new Weapon(
            ItemTypeId,
            Name,
            Price,
            MiniumumDamage,
            MaximumDamage);
    }
}