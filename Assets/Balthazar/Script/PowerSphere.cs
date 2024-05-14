using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSphere : MonoBehaviour
{
    public GameObject PowerSphereObject;
    public AudioSource PowerSound;
    public GameObject ThrowFireBallFunction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ThrowFireBallFunction.SetActive(true);
            PowerSound.Play();
            Destroy(PowerSphereObject);
        }
    }
}
