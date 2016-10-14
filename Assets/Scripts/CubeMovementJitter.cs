using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class CubeMovementJitter : CubeMovement{

    public override void move(Transform t)
    {
        int jitter = UnityEngine.Random.Range(-3, 3);
        t.position = t.position + t.forward * 3f;
        //Debug.Log("called");

        Vector3 v = t.rotation.eulerAngles;
        v.x += jitter*.1f;
        jitter = UnityEngine.Random.Range(-3, 3);
        v.y += jitter*.1f;
        jitter = UnityEngine.Random.Range(-3, 3);
        v.z += jitter*.1f;
        t.rotation = Quaternion.Euler(v);
    }
}
