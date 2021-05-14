using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float altitude;
    public int goldScore = 0;
    public int health = 10;

    public Transform m_Transform;
    public Text healthUI;
    public Text goldUI;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        altitude = m_Transform.position.y;

        goldUI.text = goldScore.ToString();
        healthUI.text = health.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Resource")
        {
            goldScore += 1;
        }

        else if (other.tag == "Obstacle")
        {
            health -= 1;
        }
    }
}
