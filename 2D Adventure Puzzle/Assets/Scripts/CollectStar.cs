﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    [SerializeField] GameManager gm;
    [SerializeField] int addStart;
    [SerializeField] AudioSource starCollect;


    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            starCollect.Play();
            Destroy(gameObject);
            gm.GiveStar();
            
        }
    }

}
