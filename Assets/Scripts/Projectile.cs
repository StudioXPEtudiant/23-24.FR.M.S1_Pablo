using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Projectile : MonoBehaviour
{
    public float Speed = 4.5f;
    public float Damages_Ennemy = 1;
    public float Damage_ice = 1;
    public float Damage_player=1;
    private float destroyTime = 20;
    
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
        if (destroyTime >0)
        {
            destroyTime-=Time.deltaTime;
        }
        if (destroyTime <= 0)
        {
            Destroy(gameObject);
        }
    }


}    
