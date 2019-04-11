using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

    [SerializeField] Animator anime;
    [SerializeField] GameObject chestEffect;
    [SerializeField] GameObject cupOfLife;


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            StartCoroutine("Chest");

        }
    }

    IEnumerator Chest()
    {
        anime.SetBool("PlayerReach", true);
        yield return new WaitForSeconds(1.5f);
        chestEffect.SetActive(true);
        cupOfLife.SetActive(true);
    }

}
