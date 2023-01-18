using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Boom!")]
public class BoomerangItem : EquipItem
{
    public float speed;
    public float stunDuration;
    public float coolDown;
    public int numberOfBounces;

    public GameObject boomObject;

    public override void OnUse(Character source)
    {
        GameObject boom = Instantiate(boomObject, source.transform.position, Quaternion.identity);
        if(boom.GetComponent<BoomerangObject>() == null)
        {
            boom.AddComponent<BoomerangObject>();
        }

        boom.GetComponent<BoomerangObject>().SetValues(speed, numberOfBounces);
    }
}
