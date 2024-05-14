using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPotion : MonoBehaviour
{
    public GameObject HelingPotion;
    public AudioSource HealthSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HealthSound.Play();
            Destroy(HelingPotion);
        }
    }
}
