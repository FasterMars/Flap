using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarManager : MonoBehaviour
{
    public Score ScoreHandlerObject;

    public SpriteRenderer PillarCostumeUpper;
    public SpriteRenderer PillarCostumeLower;

    public Sprite CobbleStonePillar_Jungle;
    public Sprite BrickPillar_Village;
    public Sprite WartPillar_Hut;
    public Sprite CobblestonePillar_Cave;
    public Sprite DarkPrismarinePillar_Reef;
    public Sprite PrismarinePillar_Monument;

    void Update()
    {
        if (Score.score < 100)
        {
            PillarCostumeLower.sprite = CobbleStonePillar_Jungle;
            PillarCostumeUpper.sprite = CobbleStonePillar_Jungle;
        }

        if (Score.score > 100)
        {
            PillarCostumeLower.sprite = BrickPillar_Village;
            PillarCostumeUpper.sprite = BrickPillar_Village;
        }

        if (Score.score > 200)
        {
            PillarCostumeLower.sprite = WartPillar_Hut;
            PillarCostumeUpper.sprite = WartPillar_Hut;
        }

        if (Score.score > 300)
        {
            PillarCostumeLower.sprite = CobblestonePillar_Cave;
            PillarCostumeUpper.sprite = CobblestonePillar_Cave;
        }

        if (Score.score > 400)
        {
            PillarCostumeLower.sprite = DarkPrismarinePillar_Reef;
            PillarCostumeUpper.sprite = DarkPrismarinePillar_Reef; 
        }

        if (Score.score > 500)
        {
            PillarCostumeLower.sprite = PrismarinePillar_Monument;
            PillarCostumeUpper.sprite = PrismarinePillar_Monument;
        }
    }
}
