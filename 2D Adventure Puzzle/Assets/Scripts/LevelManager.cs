using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] Button levelButton;
    [SerializeField] string levelToLoad;
    [SerializeField] Image lockedImage;

    private string firstLevel = "level_1";

    // Start is called before the first frame update
    void Start()
    {
       // lockedImage.gameObject.SetActive(true);
        // PlayerPrefs.SetInt("level_1", 1);

        // if (!unLocked)
        // {
        //    for (int i = 0; i < levels.Length; i++)
        //    {
        //        levels[i].interactable = false;
        //    }
        // }

        // if (PlayerPrefs.GetInt(levelToLoad) == 1)
        // {
        //     unLocked = true;
        //     lockedImage.gameObject.SetActive(false);
        // }
        // else
        // {
        //     unLocked = false;
        // }

        Debug.Log("levelToLoad: " + levelToLoad);
        Debug.Log("Level to load is unlocked: " + PlayerPrefs.GetInt(levelToLoad));

        PlayerPrefs.SetInt("level_1", 1);

        if (levelToLoad == firstLevel) {
          lockedImage.gameObject.SetActive(false);
        } else {
          if (PlayerPrefs.GetInt(levelToLoad) == 1) {
            lockedImage.gameObject.SetActive(false);
          }
          else {
            levelButton.interactable = false;
          }
        }
    }


    public void SelectStage()
    {
        if (PlayerPrefs.GetInt(levelToLoad) == 1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }

}
