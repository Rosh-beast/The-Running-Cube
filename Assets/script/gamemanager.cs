using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float restartdelay = 1f;
    public GameObject CompletelevelUI;
    public void Completelevel()
    {
        CompletelevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log  ("Game Over");
           Invoke( "Restart", restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
