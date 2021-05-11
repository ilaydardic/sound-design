using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarController : MonoBehaviour
{
    [SerializeField]
    public Transform m_Gold;

    [SerializeField]
    public Transform m_Pipe;

    [SerializeField]
    public Transform m_Radar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Resource")
        {
            GameObject[] resources = GameObject.FindGameObjectsWithTag("Resource");
            foreach(GameObject target in resources)
            {
                float goldDistance = Vector3.Distance(target.transform.position, transform.position);
                Debug.Log("Gold Found! It's " + goldDistance + " away!");
            }  
        }
        else if (other.tag == "Obstacle")
        {
            Debug.Log("Danger! Pipe!");
        }
    }
}
