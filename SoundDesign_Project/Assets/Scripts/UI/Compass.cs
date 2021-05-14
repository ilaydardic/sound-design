using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform player;
    Vector3 playerPosition;

    // Update is called once per frame
    void Update()
    {
        playerPosition.z = player.eulerAngles.y;
        transform.localEulerAngles = playerPosition;
    }
}
