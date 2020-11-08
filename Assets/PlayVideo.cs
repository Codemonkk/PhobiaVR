using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    //public GameObject videoplayer; // GameObject having the attached video
    public VideoPlayer videofile; // VideoPLayer component 

    void Start()
    {
      //  videoplayer = GameObject.Find("videoplayer"); // assigning GameObject
        //videofile = videoplayer.GetComponent<UnityEngine.Video.VideoPlayer>();
        // accessing VideoPlayer component using GetComponent<>()
    }

    public void Play()
    {
          // plays video
    }

     public void Pause()
    {
        
    }  
}
