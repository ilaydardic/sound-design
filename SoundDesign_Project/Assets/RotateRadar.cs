using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRadar : MonoBehaviour
{
    public float radarSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * radarSpeed, 0);
    }
}
