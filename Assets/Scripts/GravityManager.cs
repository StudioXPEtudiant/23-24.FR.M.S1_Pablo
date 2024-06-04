using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public GameObject other;
    public float moveSpeed = 10.0f; // Vitesse de déplacement
    private float temp = 1f;
    private bool onWall = false;

    void Update()
    {
        if (onWall)
        {
            float verticalInput = Input.GetAxis("Vertical");

            if (verticalInput > 0)
            {
                transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
            else if (verticalInput < 0)
            {
                transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }

    public void Change()
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (rb.gravityScale != 0)
            {
                temp = rb.gravityScale;
                rb.gravityScale = 0;
                onWall = true;
            }
            else
            {
                rb.gravityScale = temp;
                onWall = false;
            }
        }
    }
}
