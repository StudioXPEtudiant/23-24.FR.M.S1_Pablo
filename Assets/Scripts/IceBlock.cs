using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    public float time;
    public GameObject Player;
    private float compteur = 0;
    private CreateIceBlock createIceBlockScript;

    public void SetCreateIceBlockScript(CreateIceBlock script)
    {
        createIceBlockScript = script;
    }

    private void Update()
    {
        compteur += Time.deltaTime;
        if (compteur >= time)
        {
            compteur = 0;
            if (createIceBlockScript != null)
            {
                createIceBlockScript.Decrement();
            }
            Destroy(gameObject); // Détruire ce GameObject
        }
    }
}

