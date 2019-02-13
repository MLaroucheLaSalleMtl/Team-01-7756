using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject optionMenu;
    public static bool GameIsPaused = true;
    [SerializeField] int starCount = 0;
    public Image star1;
    public Image star2;
    public Image star3;
    public Sprite star;
    public Sprite emptyStar;



    private void Start()
    {
        
    }

    private void Update()
    {
        
    }



    //Function to add a star when player touch
    public void GiveStar(int addStar)
    {
        starCount += addStar;
        if(starCount > 3)
        {
            starCount = 3;
        }
        UpdateStarImage();
    }

    //Update the star count on the UI
    public void UpdateStarImage()
    {
        switch (starCount)
        {
            case 1: star1.sprite = star;
                    star2.sprite = emptyStar;
                    star3.sprite = emptyStar;
                    return;
            case 2:
                star1.sprite = star;
                star2.sprite = star;
                star3.sprite = emptyStar;
                return;
            case 3:
                star1.sprite = star;
                star2.sprite = star;
                star3.sprite = star;
                return;
        }
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        optionMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
