using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThrowFireballFunction : MonoBehaviour
{
    public Projectile ProjectilePrefab;
    public Transform LaunchOffSet;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown ("Fire"))
        {
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
            Debug.Log("Fire");
        }
        
    }
}
