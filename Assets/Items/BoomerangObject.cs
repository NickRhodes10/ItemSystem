using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangObject : MonoBehaviour
{
    private float _speed;
    private int _bounceCount;

    public void SetValues(float speed, int bounceCount)
    {
        _speed = speed;
        _bounceCount = bounceCount;
    }

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {
        //check it is an enemy

        if (_bounceCount > 0)
        {
            transform.forward = transform.right;
            _bounceCount--;
        }
        else
        {
            
        }
    }
}
