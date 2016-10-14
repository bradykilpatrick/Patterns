using UnityEngine;
using System.Collections;

public class DestroybyTime : MonoBehaviour
{
    public float lifetime;
    void Start()
    {
        GameObject gc = GameObject.Find("Gravity");
        Gravity g = gc.GetComponent<Gravity>();
        ArrayList subscribers = g.getSubs();
        subscribers.Remove(gameObject);
        Destroy(gameObject, lifetime);
        
    }
}
