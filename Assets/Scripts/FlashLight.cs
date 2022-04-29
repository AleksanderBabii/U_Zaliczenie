using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public bool isOn = false;
    public bool failSafe = false;

    public GameObject lightSource;

    public KeyCode lightOn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(lightOn))
        {
            if(isOn == false && failSafe == false)
            {
                failSafe = true;    
                lightSource.SetActive(true);
                isOn = true;
                StartCoroutine(FailSafe());
            }
            if(isOn == true && failSafe == false)
            {
                failSafe = true;   
                lightSource.SetActive(false);
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }
        IEnumerator FailSafe()
        {
            yield return new WaitForSeconds(0.25f);
            failSafe = false;
        }
    }
}
