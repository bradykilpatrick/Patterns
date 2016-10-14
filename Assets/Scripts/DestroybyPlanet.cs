using UnityEngine;
using System.Collections;

public class DestroybyPlanet : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Cube")
        {
            GameObject gc = GameObject.Find("Gravity"); 
            //GameObject planet = GameObject.Find("Planet");
            Gravity g = gc.GetComponent<Gravity>();
            ArrayList subscribers = g.getSubs();
            Destroy(other.gameObject);
            subscribers.Remove(other.gameObject);
            
        }
    }
}
