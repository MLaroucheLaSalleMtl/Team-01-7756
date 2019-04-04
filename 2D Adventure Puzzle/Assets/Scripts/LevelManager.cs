using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] Button levelButton;
    [SerializeField] string levelToLoad;

    [SerializeField] Image lockedImage;

    private bool levelIsUnlocked;

    private int unlockedLevel;

    private void Awake() {
      // levelIsUnlocked = (PlayerPrefs.GetInt(levelToLoad) == 1) ? true : false;
      unlockedLevel = PlayerPrefs.GetInt("currentUnlockedLevel");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("unlockedLevel: " + unlockedLevel);

        string levelsToLoad = GetLevelsToLoad();

        Debug.Log("levelsToLoad: " + levelsToLoad);

        GetUnlockedLevels(unlockedLevel, levelsToLoad);
    }

    string GetLevelsToLoad() {
      return levelToLoad.Substring(6);
    }

    void GetUnlockedLevels(int currentlyUnlocked, string levelsToLoad) {
      if (currentlyUnlocked >= int.Parse(levelsToLoad)) {
        levelIsUnlocked = true;
        lockedImage.gameObject.SetActive(false);
      } else {
        levelIsUnlocked = false;
        levelButton.interactable = false;
      }
    }

    public void SelectStage()
    {
      if (levelIsUnlocked) {
        SceneManager.LoadScene(levelToLoad);
      }
    }

}
