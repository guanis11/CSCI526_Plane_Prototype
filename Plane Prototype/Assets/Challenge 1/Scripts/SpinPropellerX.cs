using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
