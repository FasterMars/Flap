using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackdropManager : MonoBehaviour
{
    public Score ScoreHandlerObject;

    public Material BackdropJungle;
    public Material BackdropVillage;
    public Material BackdropHut;
    public Material BackdropCave;
    public Material BackdropReef;
    public Material BackdropMonument;

    void Update()
    {
        if (Score.score < 100)
        {
            RenderSettings.skybox = BackdropJungle;
        }

        if (Score.score > 100)
        {
            RenderSettings.skybox = BackdropVillage;
        }

        if (Score.score > 200)
        {
            RenderSettings.skybox = BackdropHut;
        }

        if (Score.score > 300)
        {
            RenderSettings.skybox = BackdropCave;
        }

        if (Score.score > 400)
        {
            RenderSettings.skybox = BackdropReef;
        }

        if (Score.score > 500)
        {
            RenderSettings.skybox = BackdropMonument;
        }
    }
}
