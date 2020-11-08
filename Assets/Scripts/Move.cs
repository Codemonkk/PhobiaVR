using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public GameObject player;
    

    public void MoveForward()
    {
        player.transform.Translate(0f, 0f, (1.5f));
        
    }
    public void MoveAhead()
    {
        player.transform.Translate(0f, 0f, (15.0f * Time.deltaTime));

    }
    public void Back2mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
