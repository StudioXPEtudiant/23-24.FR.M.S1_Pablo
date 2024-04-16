using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Projectile : MonoBehaviour
{
    public float Speed = 4.5f;
    public int Damages_Ennemy = 1;
    private int Damage_ice = 1;
    
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }


}    
