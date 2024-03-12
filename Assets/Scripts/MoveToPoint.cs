using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    [SerializeField]private Transform point1;
    [SerializeField]private Transform point2;
    [SerializeField]private float speed;
    // Start is called before the first frame update
    private float pos=1;
    private int sens=1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos+=(Time.deltaTime/speed)*sens;
        if (pos >=1)
        {
            pos=1;
            sens=-1;
            flip();
        }
        else if (pos <= 0)
        {
            pos=0;
            sens=1;
            flip();
        }

        transform.position=Vector3.Lerp(point1.position,point2.position,pos);
    }
    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale =localScale;
    }
}
