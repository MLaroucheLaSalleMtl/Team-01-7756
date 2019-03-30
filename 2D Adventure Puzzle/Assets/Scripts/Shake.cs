﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    private Vector3 cameraStartPos;
    [SerializeField] float shakePower = 0.05f;
    [SerializeField] float shakeDuration = 0.5f;
    [SerializeField] CutSceneOne checkEvent;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (checkEvent.eventOne)
        {
            Shaking();
        }
    }

    public void Shaking()
    {
        cameraStartPos = cam.transform.position;
        InvokeRepeating("StartShake", 0f, 0.005f);
        Invoke("StopShake", shakeDuration);
    }

    public void StartShake()
    {
        float camX = Random.value * shakePower * 2 - shakePower;
        float camY = Random.value * shakePower * 2 - shakePower;
        Vector3 camPosTwo = cam.transform.position;
        camPosTwo.x += camX;
        camPosTwo.y += camY;
        cam.transform.position = camPosTwo;
    }

    public void StopShake()
    {
        CancelInvoke("StartShake");
        cam.transform.position = cameraStartPos;
    }

}
