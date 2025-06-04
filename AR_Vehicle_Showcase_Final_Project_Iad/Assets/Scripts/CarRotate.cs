using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinOnYAxis : MonoBehaviour
{
    [Header("Rotation Speed (degrees per second)")]
    public float rotationSpeed = 90f;

    private bool isSpinning = false;

    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    // Call this from a UI Button
    public void ToggleSpin()
    {
        isSpinning = !isSpinning;
    }
}
