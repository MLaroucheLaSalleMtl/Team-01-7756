using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorExit : MonoBehaviour
{
    public GameObject panel;
    public string levelToUnlock;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "goal")
        {
            Debug.Log("levelToUnlock - " + levelToUnlock);
            PlayerPrefs.SetInt(levelToUnlock, 1);
            PlayerPrefs.Save();
            Debug.Log("Level is unlocked: " + PlayerPrefs.GetInt(levelToUnlock));
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
