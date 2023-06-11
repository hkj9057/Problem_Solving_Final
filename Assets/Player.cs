using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool jump = false;
    bool isTop = false;
    public float jumpHeight = 0;
    public float jumpSpeed = 0;

    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;        
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GameManager.instance.isPlay)
        {
            jump = true;
        }
        else if(transform.position.y <= startPosition.y)
        {
            jump = false;
            isTop = false;
            transform.position = startPosition;
        }    

        if(jump)
        {
            if(transform.position.y <= jumpHeight - 0.1f && !isTop)
            {
                transform.position = Vector2.Lerp(transform.position,
                new Vector2(transform.position.x, jumpHeight), jumpSpeed * Time.deltaTime);
            }
            else
            {
                isTop = true;
            }
            if(transform.position.y > startPosition.y && isTop)
            {
                transform.position = Vector2.MoveTowards(transform.position, startPosition, (jumpSpeed + GameManager.instance.gameSpeed -5) * Time.deltaTime);
            }
        }
    }
}
