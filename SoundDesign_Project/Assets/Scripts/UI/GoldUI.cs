using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldUI : MonoBehaviour
{
    public Text scoreText;
    public int goldScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = goldScore.ToString();
    }
}
