using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gamemanager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.Completelevel();
    }

}
