public class Character
{
    public string Name;
    public int HP;
    public string Weapon;
    public string Armor;

    public override string ToString()
    {
        return $"{Name} (HP: {HP}) - Weapon: {Weapon}, Defence: {Armor}";
    }
}
