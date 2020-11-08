using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DestroyEnemy()
    {

        enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
