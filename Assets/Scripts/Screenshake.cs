using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Cinemachine.CinemachineImpulseSource>().GenerateImpulse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
