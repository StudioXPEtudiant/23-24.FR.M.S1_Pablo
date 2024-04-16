using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject ObjectDestroy;

    public void detruire()
    {
        Destroy(ObjectDestroy);
    }
}
