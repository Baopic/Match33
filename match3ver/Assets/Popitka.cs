using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Popitka : MonoBehaviour
{
    public ScoreManager scoreManager;
    public TMP_Text highScore2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore2 = scoreManager.highScore;
    }
}
