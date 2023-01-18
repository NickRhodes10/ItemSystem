using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Melee Weapon")]
public class MeleeWeapon : WeaponEquip
{
    public WeaponType weaponType;

    public enum WeaponType
    {
        SWORD,
        SPEAR,
        MACE
    }
}
