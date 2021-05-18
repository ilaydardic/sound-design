using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [Header("Sounds")]
    public AudioSource goldCollectSound;
    public AudioSource pipeHitSound;
    public AudioSource alarmHighSound;
    public AudioSource alarmDeepSound;

    private bool alarmSoundPlayed;

    public float altitude;
    public int goldScore = 0;
    public int health = 10;

    public Transform m_Transform;
    public Text healthUI;
    public Text goldUI;
    public Text depthUI;
    
    void Update()
    {
        altitude = m_Transform.position.y;

        goldUI.text = goldScore.ToString();
        healthUI.text = health.ToString();
        depthUI.text = altitude.ToString("0");

        if (altitude >= 30 && altitude < 40)
        {
            depthUI.color = Color.yellow;

            if (!alarmSoundPlayed)
            {
                alarmHighSound.Play();
                alarmSoundPlayed = true;
            }
        }
        else if (altitude <= -30 && altitude > -40)
        {
            depthUI.color = Color.yellow;

            if (!alarmSoundPlayed)
            {
                alarmDeepSound.Play();
                alarmSoundPlayed = true;
            }
        }
        if (altitude >= 40 || altitude <= -40)
        {
            depthUI.color = Color.red;

            if (alarmHighSound.pitch == 1)
            {
                alarmHighSound.pitch += 0.1f;
            }

            if (alarmDeepSound.pitch == 1)
            {
                alarmDeepSound.pitch += .1f;
            }
        }
        else if (altitude < 30 && altitude > -30)
        {
            depthUI.color = new Color(44.0f / 255.0f, 45.0f / 255.0f, 52.0f / 255.0f, 255.0f / 255.0f);

            alarmHighSound.Stop();

            if (alarmHighSound.pitch > 1)
            {
                alarmHighSound.pitch = 1;
            }

            alarmDeepSound.Stop();
            if (alarmDeepSound.pitch > 1)
            {
                alarmDeepSound.pitch = 1;
            }

            alarmSoundPlayed = false;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Resource")
        {
            goldCollectSound.Play();
            goldScore += 1;

            Destroy(other.gameObject);
        }

        else if (other.tag == "Obstacle")
        {

            pipeHitSound.Play();
            health -= 1;

            Destroy(other.gameObject);
        }
    }
}
