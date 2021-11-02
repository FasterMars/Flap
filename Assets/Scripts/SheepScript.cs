using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SheepScript : MonoBehaviour
{
    public Lives LivesHandlerObject;
    public Text LivesText;

    public Rigidbody2D sheeprigidbody;

    public bool spacePressed;
    public bool LMBPressed;
    public bool RightArrowPressed;

    public float moveLeftForce;
    public float moveRightForce;

    public float jumpUpforce = 3f;
    public bool LeftArrowPressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            spacePressed = true;
        }
        else
        {
            spacePressed = false;
        }



        if (Input.GetButton("Right Arrow"))
        {
            RightArrowPressed = true;
        }
        else
        {
            RightArrowPressed = false;
        }



        if (Input.GetButton("Left Arrow"))
        {
            LeftArrowPressed = true;
        }
        else
        {
            LeftArrowPressed = false;
        }



        if (Input.GetMouseButton(0))
        {
            LMBPressed = true;
        }
        else
        {
            LMBPressed = false;
        }

        if (sheeprigidbody.position.y < -5.32)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (sheeprigidbody.position.y > 5.46)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void FixedUpdate()
    {
        
        if (spacePressed == true)
        {
            sheeprigidbody.velocity = new Vector2(sheeprigidbody.velocity.x, jumpUpforce);
        }

        if (LMBPressed == true)
        {
            sheeprigidbody.velocity = new Vector2(sheeprigidbody.velocity.x, jumpUpforce);
        }

        if (RightArrowPressed == true)
        {
            sheeprigidbody.velocity = new Vector2(moveRightForce, sheeprigidbody.velocity.y);
        }

        if (LeftArrowPressed == true)
        {
            sheeprigidbody.velocity = new Vector2(moveLeftForce, sheeprigidbody.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collisionWithPillar)
    {
        if (Lives.lives > 0)
        {
            Lives.lives = Lives.lives - 1;
            Debug.Log(Lives.lives.ToString());
        }

        LivesText.text = "Lives : " + Lives.lives.ToString();

    }
}
