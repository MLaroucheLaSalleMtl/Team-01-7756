using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneOne : MonoBehaviour
{
    //The platform
    [SerializeField] GameObject movingObject;
    //Position of both point
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] Transform zPoint;
    //Speed for moving the brick
    [SerializeField] float moveSpeed = 5f;
    //To save the current position of the platform/object
    private Vector3 currentTarget;
    public Animator anime;
    public bool eventOne = false;
    [SerializeField] GameObject textSurprise;
    



    // Start is called before the first frame update
    void Start()
    {
        textSurprise.SetActive(false);
        anime = GetComponent<Animator>();
        currentTarget = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Moving to the end point
        movingObject.transform.position = Vector2.MoveTowards(movingObject.transform.position, currentTarget, moveSpeed * Time.deltaTime);


        if (movingObject.transform.position.y == startPoint.position.y)
        {
            currentTarget = endPoint.position;
        }
        if (movingObject.transform.position.y == endPoint.position.y)
        {
            anime.SetBool("Reach", true);
            eventOne = true;
            StartCoroutine("Emote");
        }
    }

    IEnumerator Emote()
    {
        yield return new WaitForSeconds(1.5f);
        textSurprise.SetActive(true);
        if(movingObject.transform.position.y == endPoint.position.y)
        {
            currentTarget = zPoint.position;
        }
    }


}
