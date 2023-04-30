using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    public Vector3 RotateVector;
    private void FixedUpdate()
    {
        transform.Rotate(RotateVector);
    }
}
