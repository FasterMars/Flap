using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Lives LivesHandlerObject;
    public static float score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives.lives != 0)
        {
            score = score + 0.03f;
        }
        scoreText.text = score.ToString("0");
    }
}
