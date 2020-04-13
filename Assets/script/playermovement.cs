using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.CrossPlatformInput;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
   // public GameObject  Character;
    private float moveSpeed =100f;

    private float forwardForce = 800f;
    private float sidewaysForce = 700f;

   // private Rigidbody2D characterBody;
    private float ScreenWidth;

     void Start()
    {
        ScreenWidth = Screen.width;
        rb = rb.GetComponent<Rigidbody>();
    }

     void Update()
    {
        /*   int i = 0;
            while(i< Input.touchCount)
            {
                if (Input.GetTouch(i).position.x > ScreenWidth/2)
                {

                    RunCharacter(6.0f);  //left touch
                   Debug.Log("left");
                }
                if (Input.GetTouch(i).position.x < ScreenWidth / 2)
                {
                    RunCharacter(-6.0f);  //Right touch
                   Debug.Log("right");
               }
                ++i;
           }   */

     

    }
    private void RunCharacter(float horizontalInput)
    {
      rb.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }


     bool isSlow = false;

    
     void FixedUpdate()
        {

        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                isSlow = true;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled)
            {
                isSlow = false;
            }
        }

        if (isSlow) {
            Debug.Log("isSlow: true");
           // rb.AddForce(0, 0, 600 * Time.deltaTime);
        }
        else {
            Debug.Log("isSlow: false");
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }   




        rb.AddForce(Input.acceleration.x * sidewaysForce * Time.deltaTime, 0, 0);


        if (Input.GetKey("d"))
           {
               rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
           }
           if (Input.GetKey("a"))
           {
               rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); // sideforce
           }

       

        if (rb.position.y < -1f)
            {
                FindObjectOfType<gamemanager>().Endgame();  //Game manager

            }
        }
    }
