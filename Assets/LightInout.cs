using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInout : MonoBehaviour
{
    int count = 0;
    int temp;

    public GameObject light1, light2, light3, light4, light5, light6;
    // Start is called before the first frame update
    void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        light5.SetActive(false);
        light6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        temp = count / 30;
        Debug.Log(temp);
        if(temp==1)
        {
            light1.SetActive(true);
        }
        if (temp==2)
        {
            light2.SetActive(true);
            light1.SetActive(false);
        }
        if (temp==3)
        {
            light3.SetActive(true);
            light2.SetActive(false);
            light1.SetActive(false);
        }
        if (temp==4)
        {
            light4.SetActive(true);
            light3.SetActive(false);
            light2.SetActive(false);
            light1.SetActive(false);
        }
        if (temp==5)
        {
            light5.SetActive(true);
            light4.SetActive(false);
            light3.SetActive(false);
            light2.SetActive(false);
            light1.SetActive(false);
        }
        if (temp==6)
        {
            light6.SetActive(true);
            light5.SetActive(false);
            light4.SetActive(false);
            light3.SetActive(false);
            light2.SetActive(false);
            light1.SetActive(false);
        }
        if (temp==7)
        {
            count = 0;
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            light6.SetActive(false);
        }
    }
}
