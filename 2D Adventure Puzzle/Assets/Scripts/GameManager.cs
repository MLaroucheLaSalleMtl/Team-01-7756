using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject optionMenu;
    public AudioSource deathSound;
    public static bool GameIsPaused = true;
    public GameObject loadingPanel;
    [SerializeField] int starCount = 0;
    public Image star1;
    public Image star2;
    public Image star3;
    public Sprite star;
    public Sprite emptyStar;
    public bool respawnCoActive;
    [SerializeField] PlayerController player;
    [SerializeField] GameObject deathEffect;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Respawn()
    {
        deathSound.Play();
        StartCoroutine("RespawnCo");      
    }

    //Have it own time to respawn
    public IEnumerator RespawnCo()
    {
        //player off then death effect , wait 1.5sec then respawn
        player.gameObject.SetActive(false);
        Instantiate(deathEffect, player.gameObject.transform.position, player.gameObject.transform.rotation);
        yield return new WaitForSeconds(1.5f);
        
        player.gameObject.SetActive(true);
        player.gameObject.transform.position = player.respawnPosition;
    }

    //Function to add a star when player touch
    public void GiveStar()
    {     
        starCount++;
       
        if (starCount > 3)
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

    //for the level selection
    public void LoadScene(int level)
    {
        loadingPanel.SetActive(true);
        SceneManager.LoadScene(level);
    }

}
