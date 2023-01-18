using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effect/Missile")]
public class MissileEffect : EffectBase
{
    public GameObject missileObject;
    public float speed;

    public override void OnTrigger(Character source)
    {
        GameObject missile = Instantiate(missileObject, source.transform.position, Quaternion.identity);
    }
}
