using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponEquip : EquipItem
{
    public EffectBase[] onHitEffects;

    public float damageValue;

    public virtual void OnHit(Character source)
    {
        for (int i = 0; i < onHitEffects.Length; i++)
        {
            onHitEffects[i].OnTrigger(source);
        }
    }


}
