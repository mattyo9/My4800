using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong dude";
        Stamina = 15;
        Endurance = 12;
        Strength = 20;
        Intellect = 5;

    }
}
