using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrine : MonoBehaviour
{
    public float bounceSpeed;
    public float bounceAmplitude;
   
    private float startingHeight;
    private float timeOffset;
    private float finalHeight;


    // Start is called before the first frame update
    void Start()
    {
        startingHeight = transform.localPosition.y;
        timeOffset = Random.value * Mathf.PI * 2;
    }

    // Update is called once per frame
    void Update()
    {
        // Bounce Anim
        finalHeight = startingHeight + Mathf.Sin(Time.time * bounceSpeed / timeOffset) * bounceAmplitude;
        var position = transform.localPosition;
        position.y = finalHeight;
        transform.localPosition = position;

    }

  
}
