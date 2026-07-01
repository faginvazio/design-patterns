using UnityEngine;

[CreateAssetMenu(menuName = "CharacterPreset")]
public class CharacterPreset : ScriptableObject
{
    public string characterName;
    public int hp;
    public string weapon;
    public string armor;
}
