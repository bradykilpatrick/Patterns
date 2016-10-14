using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class CubeMovementNoGravity : CubeMovement
{

    public override void move(Transform t)
    {
        t.position = t.position + t.forward * 3f;
    }
}
