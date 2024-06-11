using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateIceBlock : MonoBehaviour
{
    public GameObject IceBlockPrefab;
    public Transform LaunchOffSet;

    public int max;
    private int count;

    private void Update()
    {
        if (Input.GetButtonDown("CreateIce") && (count < max)) // Utilisation de < au lieu de <= pour limiter à 'max' objets
        {
            count += 1;
            GameObject iceBlock = Instantiate(IceBlockPrefab, LaunchOffSet.position, transform.rotation);
            IceBlock iceBlockScript = iceBlock.GetComponent<IceBlock>();

            if (iceBlockScript != null)
            {
                iceBlockScript.SetCreateIceBlockScript(this); // Passer la référence à CreateIceBlock script
            }
        }
    }

    public void Decrement()
    {
        count -= 1;
        Debug.Log("Count decreased: " + count); // Debug log pour vérifier la décrémentation
    }
}
