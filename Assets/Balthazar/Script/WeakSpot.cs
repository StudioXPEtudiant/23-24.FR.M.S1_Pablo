using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject ObjectDestroy;
    public AudioSource killSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            killSound.Play();
            Destroy(ObjectDestroy);            
        }
    }
}
