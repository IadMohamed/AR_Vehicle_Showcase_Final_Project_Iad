using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinOnYAxis : MonoBehaviour
{
    [Header("Rotation Speed (degrees per second)")]
    public float rotationSpeed = 90f;

    void Update()
    {
        // Rotate clockwise around the Y-axis (like a spinning display or turntable)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
