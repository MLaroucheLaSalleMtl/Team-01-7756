using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    //The platform
    [SerializeField] GameObject movingObject;
    //Position of both point
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    //Speed for moving the brick
     [SerializeField] float moveSpeed = 5f;
    //To save the current position of the platform/object
    private Vector3 currentTarget;




    // Start is called before the first frame update
    void Start()
    {
        currentTarget = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Moving to the end point
        movingObject.transform.position = Vector2.MoveTowards(movingObject.transform.position, currentTarget, moveSpeed * Time.deltaTime);

        if (movingObject.transform.position.y == endPoint.position.y)
        {
            currentTarget = startPoint.position;
        }
        if (movingObject.transform.position.y == startPoint.position.y)
        {
            currentTarget = endPoint.position;
        }
    }
}

