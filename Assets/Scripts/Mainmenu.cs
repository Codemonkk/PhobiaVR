using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRSettings.enabled = false;
    }

    public void GotoSleep()
    {
        SceneManager.LoadScene("Sound");
    }
    

    public void GotoPB()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene("New");
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoVoiceDiary()
    {
        SceneManager.LoadScene("VoiceDiary");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
