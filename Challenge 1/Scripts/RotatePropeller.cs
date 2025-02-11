using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float rotationSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Use forward since propellor rotates across z-axis so we want (0,0,1)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
