using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("Sounds")]
    public AudioSource lightOff;
    public AudioClip lightOffClip;
    public AudioSource heatSound;

    [Header("Altitude Tracker")]
    //Player's y position
    public float altitude;
    public Transform playerTransform;

    [Header("Light Manager")]
    public Canvas darkImage;
    //How long the light will stay on
    public float lightOnTimer = 60f;
    //How long the light will stay off
    public float lightOffTimer = 10f;    
    public float lightCountdown;
    //Keeps track of the light status
    public bool lightsOff;

    private bool lightSoundPlayed;
    private bool heatSoundPlayed;

    public float heatSoundStart = 10;
    public float heatSoundEnd = 0;

    void Start()
    {     
        lightCountdown = lightOnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //Keep track of player's altitude
        altitude = playerTransform.position.y;

        //Play sounds based on the player's altitude
        AltitudeWarning();

        LightCountdown();

        LightsOut();

        LightOffSound();

        if (lightCountdown <= heatSoundStart && !heatSoundPlayed && !lightsOff)
        {
            Debug.Log("Blio");
            heatSound.Play();
            heatSoundPlayed = true;
        }
        else if (lightsOff == true)
        {
            heatSound.Stop();
            heatSoundPlayed = false;
        }
    }

    void AltitudeWarning()
    {
        if (altitude >= 20)
        {
            //Play sound
        }
        else if (altitude <= -20)
        {
            //Play sound
        }
    }

    void LightCountdown()
    {
        lightCountdown -= Time.deltaTime * 1;

        if (lightCountdown <= 0 && lightsOff == false)
        {
            lightsOff = true;
            lightCountdown = lightOffTimer;
        }
        else if (lightCountdown <= 0 && lightsOff == true)
        {
            lightsOff = false;
            lightCountdown = lightOnTimer;
        }
    }

    void LightsOut()
    {
        if (lightsOff == true)
        {
            darkImage.enabled = true;
        }
        else
        {
            darkImage.enabled = false;
            lightSoundPlayed = false;
        }

    }

    void LightOffSound()
    {
        if (lightsOff == true && lightSoundPlayed == false)
        {
            lightOff.Play();
            lightSoundPlayed = true;
        }
    }
}
