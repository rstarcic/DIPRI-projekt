using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    public Light light;
    public float minTime;
    public float maxTime;
    private float timer;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        flickerLight();
    }

    void flickerLight()
    {
        if (light == null)
        {
            Debug.LogWarning("Light object is not assigned to the NewBehaviourScript!");
            return;
        }

        if (timer > 0)
            timer -= Time.deltaTime;

        if (timer <= 0)
        {
            light.enabled = !light.enabled;
            timer = Random.Range(minTime, maxTime);
        }
    }
}