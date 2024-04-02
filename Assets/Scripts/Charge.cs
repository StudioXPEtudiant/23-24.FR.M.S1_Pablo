using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    [SerializeField]private Transform player;
    [SerializeField]private float speed_charge;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > transform.position.x)
        {
            transform.position += Vector3.right * speed_charge*Time.deltaTime;
        }
        else if (player.position.x < transform.position.x)
        {
            transform.position -= Vector3.right * speed_charge*Time.deltaTime;
        }   
    }
}