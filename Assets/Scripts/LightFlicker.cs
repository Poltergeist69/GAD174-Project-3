using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;
    
    public Light lightSource;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
        lightSource = GameObject.Find("Spot Light").GetComponent<Light>();  
    }


    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            lightSource.enabled= true;
        }
        if (timer < 0)
        {
            lightSource.enabled = false;
            timer = Random.Range(minTime, maxTime);
        }
    }
}
