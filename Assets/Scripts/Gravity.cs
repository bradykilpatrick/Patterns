using UnityEngine;
using System.Collections;

[System.Serializable]
public class Gravity : MonoBehaviour {
    ArrayList subscribers = new ArrayList();
    

	// Use this for initialization
	void Start () {
	
	}
   
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            //Destroy(other.gameObject);
            //change path of gameObject as it enters gravity
            subscribers.Add(other.gameObject);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            //Destroy(other.gameObject);
            //change path of gameObject as it enters gravity
            subscribers.Remove(other.gameObject);
        }
    }
    public ArrayList getSubs()
    {
        return subscribers;
    }
}
