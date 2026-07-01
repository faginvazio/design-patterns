using UnityEngine;

public class CharacterFactory
{
    public static Character BuildFromPreset(CharacterPreset characterPreset)
    {
        return new CharacterBuilder()
            .SetName(characterPreset.characterName)
            .SetHP(characterPreset.hp)
            .SetWeapon(characterPreset.weapon)
            .SetArmor(characterPreset.armor)
            .Build();
    }
}
