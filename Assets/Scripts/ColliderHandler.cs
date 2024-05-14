using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderHandler : MonoBehaviour
{
    [SerializeField] private string[] Tags={"Texte"};
    [SerializeField] private UnityEvent<GameObject> OnEnter;
    [SerializeField] private UnityEvent<GameObject> OnExit;

    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if((Tags.Length>0&&as_tag(col.gameObject.tag))||Tags.Length==0)
        {
            OnEnter.Invoke(col.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if((Tags.Length>0&&as_tag(col.gameObject.tag))||Tags.Length==0)
        {
            OnExit.Invoke(col.gameObject);
        }
    }
    bool as_tag(string toCheck)
    {
        foreach(string t in Tags)
        {
            if(t==toCheck)
            {
                return true;
            }
        }
        return false;
    }
}