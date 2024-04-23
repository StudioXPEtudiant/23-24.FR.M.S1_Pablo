using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateIceBlock : MonoBehaviour
{
    public GameObject IceBlockPrefab;
    public Transform LaunchOffSet;

    public int count;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown ("CreateIce"))
        {
            Instantiate(IceBlockPrefab, LaunchOffSet.position, transform.rotation);
        }
        
    }
}