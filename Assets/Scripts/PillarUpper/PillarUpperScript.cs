using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarUpperScript : MonoBehaviour
{
    public Rigidbody2D pillarUpperRB;
    public Transform pillarUpperTransform;

    public float speed;
    public float upperPillarAltitude;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        if (pillarUpperTransform.position.x < -10f)
        {
            pillarUpperTransform.position = new Vector2(10.02f, Random.Range(3.72f, 4.84f));
        }

        pillarUpperRB.velocity = new Vector2(speed, 0f);
    }

    public void GeneratePos()
    {
        float Pos = Random.Range(3.62f, 4.84f);
    }
}
