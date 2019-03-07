using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InitiateHelper : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] float timer = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0) {
          panel.SetActive(false);
        }
    }
}
