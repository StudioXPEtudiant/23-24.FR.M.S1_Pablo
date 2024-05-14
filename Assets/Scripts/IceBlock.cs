using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IceBlock : MonoBehaviour
{
    public float time;
    public GameObject ObjectDestroy;
    private float incrementAmount = 1;
    private float compteur = 0;

    private void Start()
    {
        InvokeRepeating("Increment", 1, 1);
    }
    private void Update()
    {
        if (compteur==time)
        {
            Destroy(ObjectDestroy);
        }
    }

    private void Increment()
    {
        compteur += incrementAmount;
    }
}    
