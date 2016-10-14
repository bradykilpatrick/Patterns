using UnityEngine;
using System.Collections;

[System.Serializable]
public class cube : MonoBehaviour {

    public CubeMovement cubemoveForward = new CubeMovementForward();
    public CubeMovement cubemoveJitter = new CubeMovementJitter();
    public CubeMovement cubemoveFree = new CubeMovementFree();
    public CubeMovement cubemoveNoGravity = new CubeMovementNoGravity();
    public CubeMovement cubemove;
    public int cubeType;
	// Use this for initialization
	void Start () {
        
        cubeType = Random.Range(0, 4);
        if(cubeType == 0)
        {
            cubemove = cubemoveForward;
        }
        else if(cubeType == 1)
        {
            cubemove = cubemoveJitter;
        }
        else if (cubeType == 2)
        {
            cubemove = cubemoveFree;
            
        }
        else if (cubeType == 3)
        {
            cubemove = cubemoveNoGravity;

        }

        //Debug.Log(cubemove);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        cubemove.move(transform);

	}
    public bool noGravity()
    {
        if (cubemove == cubemoveNoGravity)
        {
            return true;
        }
        else
            return false; 
    }
}
