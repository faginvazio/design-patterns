using UnityEngine;

public class CharacterBuilder
{
    private Character character = new Character();

    public CharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }
    public CharacterBuilder SetHP(int HP)
    {
        character.HP = HP;
        return this;
    }
    public CharacterBuilder SetWeapon(string weapon)
    {
        character.Weapon = weapon;
        return this;
    }
    public CharacterBuilder SetArmor(string armor)
    {
        character.Armor = armor;
        return this;
    }

    public Character Build()
    {
        return character;
    }
}
