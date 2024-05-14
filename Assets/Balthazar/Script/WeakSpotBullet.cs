using UnityEngine;

public class WeakSpotBullet : MonoBehaviour
{
    public GameObject ennemy;
    public AudioSource killSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            killSound.Play();
            Destroy(ennemy);
        }
    }
}