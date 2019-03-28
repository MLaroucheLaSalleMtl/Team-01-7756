using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    [SerializeField] string stageName;
    //public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        
        SceneManager.LoadScene(stageName);
        //Time.timeScale = 1;
        //panel.SetActive(false);
    }

}
