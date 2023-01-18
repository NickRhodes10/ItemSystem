using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipItem : ItemBase
{
    public virtual void OnUse(Character source) { }

    public virtual void OnEquip()
    {

    }

    public virtual void OnUnequip()
    {

    }
}
