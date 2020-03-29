using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoliision : MonoBehaviour
{
    public playermovement movement;
    public gamemanager gameManager;
    private void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
    void Update()
    {
        
    }
}
