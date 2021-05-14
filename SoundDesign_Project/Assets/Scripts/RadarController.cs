using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadarController : MonoBehaviour
{
    [SerializeField]
    public Transform m_Gold;

    [SerializeField]
    public Transform m_Pipe;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Resource")
        {
            float goldDistance = Vector3.Distance(other.transform.position, transform.position);
            Debug.Log("Gold Found! It's " + goldDistance + " away!");
        }
        else if (other.tag == "Obstacle")
        {
            float goldDistance = Vector3.Distance(other.transform.position, transform.position);
            Debug.Log("Pipe Found! It's " + goldDistance + " away!");
        }
    }   
}
