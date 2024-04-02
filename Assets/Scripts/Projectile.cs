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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != 14)
        {
            Destroy(gameObject);
        }
        /*else if(collision.gameObject.layer == 15)
        {
            hp=collision.gameObject.GetComponent<Health>();
            hp.decrease(Damages_Ennemy);
        }
        else if(collision.gameObject.layer == 16)
        {
            hp=collision.gameObject.GetComponent<Health>();
            hp.decrease(Damage_Ice);
        }*/
    }
}    
