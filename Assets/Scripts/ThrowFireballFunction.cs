using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThrowFireballFunction : MonoBehaviour
{
    public Projectile ProjectilePrefab;
    public Transform LaunchOffSet;

    public float cooldown;
    private float currentTime=0;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if (currentTime >0)
        {
            currentTime-=Time.deltaTime;
        }
        if (Input.GetButtonDown ("Fire") && currentTime <= 0)
        {
            currentTime=cooldown;
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
        
    }
}
