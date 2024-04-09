using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFunction : MonoBehaviour
{
    public Transform checkSol;
    bool toucheLeSol = false;
    float rayonSol =0.3f;
    public LayerMask Sol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate () 
    {
        toucheLeSol = Physics2D.OverlapCircle (checkSol.position, rayonSol, Sol);
    }

    // Update is called once per frame
    void Update()
    {
        if (toucheLeSol && Input.GetButtonDown ("Jump")) 
        {
            GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 325));
        }

    }
}
