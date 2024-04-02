using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPointAndCharge : MonoBehaviour
{
    [SerializeField]private Transform point1;
    [SerializeField]private Transform point2;
    [SerializeField]private Transform player;
    [SerializeField]private float speed;
    [SerializeField]private float speed_charge;
    // Start is called before the first frame update
    private float pos=1;
    private int sens=1;
    private bool in_charge=false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x > point1.position.x && transform.position.x < point2.position.x) && (transform.position.y > point1.position.y && transform.position.y < point2.position.y) && (in_charge == false))
        {
            Walk();
        }
        /*else if (in_charge==false)
        {
            ComeBack();
        }*/

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            Charge();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            in_charge=false;
            ComeBack();
        }
        
    }
    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void Walk()
    {
        pos += (Time.deltaTime / speed) * sens;
        if (pos >= 1)
        {
            pos = 1;
            sens = -1;
            Flip();
        }
        else if (pos <= 0)
        {
            pos = 0;
            sens = 1;
            Flip();
        }

        transform.position = Vector3.Lerp(point1.position, point2.position, pos);
    }

    private void Charge()
    {
        in_charge=true;
        if (player.position.x > transform.position.x)
        {
            transform.position += Vector3.right * speed_charge;
        }
        else if (player.position.x < transform.position.x)
        {
            transform.position -= Vector3.right * speed_charge;
        }
        
    }

    private void ComeBack()
    {
        if (transform.position.x < point1.position.x)
        {
            transform.position += Vector3.right * speed;
        }
        else if (transform.position.x > point2.position.x)
        {
            transform.position -= Vector3.right * speed;
        }
    }
}