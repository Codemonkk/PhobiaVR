using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallerMap : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pannel1;
    public GameObject pannel3;

    public void s1()
    {
        pannel1.SetActive(true);
        pannel3.SetActive(false);
    }
    public void s3()
    {
        pannel3.SetActive(true);
        pannel1.SetActive(false);
    }

    public void callA()
	{
		Application.OpenURL("tel://+9102227546669");

	}
    public void callB()
    {
        Application.OpenURL("tel://+9118602662345");

    }
    public void callC()
    {
        Application.OpenURL("tel://+912225563291");

    }
    public void callD()
    {
        Application.OpenURL("tel://+911800233330");

    }
    public void callMA()
    {
        Application.OpenURL("https://goo.gl/maps/JxAeGwUztSvYjoUq6");

    }
    public void callMB()
    {
        Application.OpenURL("https://goo.gl/maps/EQSKEFKkWNZbwJWp6");

    }
    public void callMC()
    {
        Application.OpenURL("https://goo.gl/maps/S8ddHLqC6cFhdGoE8");

    }
    public void callMD()
    {
        Application.OpenURL("https://goo.gl/maps/AJSLMAu7M1Azys9M7");

    }
}
