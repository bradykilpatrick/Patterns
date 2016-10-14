using UnityEngine;
using System.Collections;

[System.Serializable]
public class FactoryScript : MonoBehaviour {

    public GameObject o;
    private GameObject gc;
    



    // Use this for initialization
    void Start () {
        StartCoroutine(spawnCubes());
        gc = GameObject.Find("Gravity");
    }

    IEnumerator spawnCubes()
    {
        while(true)
        {
            int height = Random.Range(-200, 200);
            Vector3 v = new Vector3(-150, height, -300);
            Vector3 r = new Vector3( 0 , 30 , 0 );

            Object obj = Instantiate(o, v, Quaternion.Euler(r));
            GameObject go = (GameObject)obj;
            cube c = go.GetComponent<cube>();
            c.cubemove = new CubeMovementForward();

            yield return new WaitForSeconds(.1f);

        }
    }
	
	// Update is called once per frame
	void Update () {
        GameObject planet = GameObject.Find("Planet");
        Gravity g = gc.GetComponent<Gravity>();
        ArrayList subscribers = g.getSubs();
      foreach(GameObject sub in subscribers)
        {
            //Destroy(sub);
            //subscribers.Remove(sub);
            cube thiscube = sub.GetComponent<cube>();
            if (!thiscube.noGravity())
            {
                Vector3 diff = sub.transform.position - planet.transform.position;

                diff.Normalize();
            
                sub.transform.position -= diff * 1f;
            }
            
            
        }
	}
}
 