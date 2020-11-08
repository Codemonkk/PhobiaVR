using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.Video;

public class GazingVR : MonoBehaviour
{
    public Image imgGaze;
    public VideoPlayer videofile;
    public GameObject PhobiaBG;
    public GameObject MeditationBG;

    public float totalTime = 1.0f;
    bool gvrStatus;
    float gvrTimer;

    public int distanceofRay = 40;
    private RaycastHit _hit;


    // Start is called before the first frame update
     void Start()
    {
        XRSettings.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceofRay))
        {
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Therapy"))
            {
                Debug.Log("Collision");
                
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Meditation"))
            {
                //SceneManager.LoadScene("360VR");
                MeditationBG.SetActive(true);

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Audi"))
            {
                Debug.Log("Collision");

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Motivate"))
            {
                SceneManager.LoadScene("Motiv");

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Phobia"))
            {
                PhobiaBG.SetActive(true);

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Anger"))
            {
                Debug.Log("Collision");

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Finish"))
            {
                XRSettings.enabled = false;
                SceneManager.LoadScene("MainMenu");

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("ExitMuseum"))
            {
                XRSettings.enabled = true;
                SceneManager.LoadScene("New");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Play"))
            {
                videofile.playbackSpeed = 1;
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Pause"))
            {
                videofile.playbackSpeed = 0;
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Back2Menu"))
            {
                PhobiaBG.SetActive(false);
                MeditationBG.SetActive(false);
                GVROff();
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Height"))
            {
                SceneManager.LoadScene("PhobiaHeight");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Dark"))
            {
                SceneManager.LoadScene("PhobiaDark");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("EDMR"))
            {
                SceneManager.LoadScene("EDMR");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Angel"))
            {
                SceneManager.LoadScene("360VR1");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Mount"))
            {
                SceneManager.LoadScene("360VR");
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Hypno"))
            {
                SceneManager.LoadScene("Hypnosis");
            }

        }

        
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

    

   
}