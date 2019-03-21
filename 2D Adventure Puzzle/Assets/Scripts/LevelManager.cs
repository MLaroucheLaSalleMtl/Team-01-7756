using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] Button[] levels;
    [SerializeField] int size = 5;
    [SerializeField] string levelToLoad;
    [SerializeField] bool unLocked;
    [SerializeField] Image lockedImage;

    // Start is called before the first frame update
    void Start()
    {
       // lockedImage.gameObject.SetActive(true);
        PlayerPrefs.SetInt("lv_1_tutorial", 1);

        //if (!unLocked)
        //{
        //    for (int i = 0; i < levels.Length; i++)
        //    {
        //        levels[i].interactable = false;
        //    }
        //}

        if (PlayerPrefs.GetInt(levelToLoad) == 1)
        {
            unLocked = true;
            lockedImage.gameObject.SetActive(false);

        }
        else
        {
            unLocked = false;
        }
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SelectStage()
    {
        if (unLocked)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }

}
