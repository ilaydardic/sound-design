using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMeter : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerScript = GameObject.Find("PlayerController");
        PlayerController controllerScript = playerScript.GetComponent<PlayerController>();
        float playerSpeed = controllerScript.currentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
