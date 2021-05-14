using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepthUI : MonoBehaviour
{
    public Transform player;
    public Text depthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        depthText.text = player.position.y.ToString("0");
    }
}
