using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EduController : MonoBehaviour
{
    string btname;
    int counter = 0;
    public GameObject ForwardArrow;
    public GameObject BackwardArrow;
    public GameObject platform;
    public GameObject platform_02;
    public GameObject platform_03;
    public GameObject platform_04;
    public GameObject plane;
    //public GameObject pill;
    // Start is called before the first frame update
    void Start()
    {
        BackwardArrow.SetActive(false);
        platform_02.SetActive(false);
        plane.SetActive(false);
        platform_03.SetActive(false);
        platform_04.SetActive(false);
        platform.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))

            {
                btname = Hit.transform.name;
                switch (btname)
                {
                    case "ForwardArrow":
                        counter++;
                        //_ShowAndroidToastMessage("Arrow clicked " + counter + " times" );
                        if(counter==1)
                        {
                            BackwardArrow.SetActive(true);
                            ForwardArrow.SetActive(true);
                            platform_02.SetActive(true);
                            plane.SetActive(true);
                            platform.SetActive(false);
                        }
                        if (counter == 2)
                        {
                            platform_02.SetActive(false);
                            plane.SetActive(false);
                            platform.SetActive(false);
                            BackwardArrow.SetActive(true);
                            ForwardArrow.SetActive(true);
                            platform_03.SetActive(true);  
                        }
                        if (counter == 3)
                        {
                            platform_03.SetActive(false);
                            BackwardArrow.SetActive(true);
                            ForwardArrow.SetActive(false);
                            platform_04.SetActive(true);
                        }
                        
                        break;
                    case "BackArrow":
                        counter--;
                        if(counter < 1)
                        {
                            BackwardArrow.SetActive(false);
                            platform.SetActive(true);
                            ForwardArrow.SetActive(true);
                            platform_02.SetActive(false);
                            plane.SetActive(false);
                        }
                        if (counter == 1)
                        {
                            BackwardArrow.SetActive(true);
                            ForwardArrow.SetActive(true);
                            platform_02.SetActive(true);
                            platform_03.SetActive(false);
                            plane.SetActive(true);
                            platform.SetActive(false);
                            platform_04.SetActive(false);

                        }
                        if (counter == 2)
                        {
                            ForwardArrow.SetActive(true);
                            platform_03.SetActive(true);
                            platform_02.SetActive(false);
                            plane.SetActive(false);
                            platform.SetActive(false);
                            platform_04.SetActive(false);
                        }
                        if (counter == 3)
                        {
                            ForwardArrow.SetActive(false);
                            platform_03.SetActive(false);
                            platform_02.SetActive(false);
                            platform_04.SetActive(true);
                            plane.SetActive(false);
                            platform.SetActive(false);
                        }

                        //_ShowAndroidToastMessage("BackArrow clicked " + counter + " times");
                        break;
                    case "ExitSign":
                        _ShowAndroidToastMessage("Exit clicked");
                        //anim.clip = trajectory;
                        //anim.Play();
                        SceneManager.LoadScene("StaffMainMenu");
                        break;

                }
            }
        }
    }


    private void _ShowAndroidToastMessage(string message)
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity =
            unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        if (unityActivity != null)
        {
            AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
            unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
            {
                AndroidJavaObject toastObject =
                    toastClass.CallStatic<AndroidJavaObject>(
                        "makeText", unityActivity, message, 0);
                toastObject.Call("show");
            }));
        }
    }
}
