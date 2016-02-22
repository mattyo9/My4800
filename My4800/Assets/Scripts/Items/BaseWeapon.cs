using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM
    }

    private WeaponTypes weaponType;

    private int spellEffectID; //Down the road we can add this

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set {spellEffectID = value;}
    }
}
