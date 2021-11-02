using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public Score ScoreObject;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void restartMainGame()
    {
        Score.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
