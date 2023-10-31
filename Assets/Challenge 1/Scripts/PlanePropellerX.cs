using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around the Z-axis
        transform.Rotate(Vector3.forward * Time.deltaTime * 360); // 360 degrees per second
    }
}
