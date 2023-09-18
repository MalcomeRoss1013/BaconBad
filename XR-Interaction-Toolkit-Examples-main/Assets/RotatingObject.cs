using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotationSpeed = 300f; // Adjust this value to control the rotation speed

    void Update()
    {
        // Rotate the object around its local Y-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}

