using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarLowerScript : MonoBehaviour
{

    public Rigidbody2D pillarLowerRB;
    public Transform pillarLowerTransform;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pillarLowerTransform.position.x < -10f)
        {
            pillarLowerTransform.position = new Vector2(10.02f, Random.Range(-5.33f, -4.2f));
        }

        pillarLowerRB.velocity = new Vector2(speed, 0f);
    }

}
