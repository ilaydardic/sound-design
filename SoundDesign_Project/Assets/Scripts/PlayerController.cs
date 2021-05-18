using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Sounds")]
    public AudioSource speedSoundNormal;

    private bool speedSoundPlayed;

    [Header("Vehicle UI")]
    public RectTransform speedMeter;

    public float rotationSpeed = 0.5f;

    [Header("Vehicle Speed Settings")]
    public float playerSpeedSlow = 5f;
    public float playerSpeedMid = 10f;
    public float playerSpeedFast = 15f;
    public float currentSpeed;
    public float speedChange = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = playerSpeedSlow;

        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Keep player moving
        MovePlayer();

        //Change player speed
        changeMovementSpeed();

        //Turn left and right
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Time.deltaTime * -rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
        }

        //Change altitude
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Time.deltaTime * -rotationSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Time.deltaTime * rotationSpeed, 0, 0);
        }
    }

    void MovePlayer()
    {
        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }

    void changeMovementSpeed()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentSpeed < playerSpeedFast)
        {
            currentSpeed += speedChange;
            speedSoundNormal.pitch += .1f;
            speedMeter.Rotate(0, 0, -60);
        }

        if (Input.GetKeyDown(KeyCode.S) && currentSpeed > playerSpeedSlow)
        {
            currentSpeed -= speedChange;
            speedSoundNormal.pitch -= .1f;
            speedMeter.Rotate(0, 0, +60);
        }
    }
}
