using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass 
{
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "Wise Mage";
        Stamina = 10;
        Strength = 5;
        Intellect = 25;
        Endurance = 10;
    }


}
