using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMob : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;
    bool jump = true;
    bool isTop = false;
    public float jumpHeight = 0;
    public float jumpSpeed = 0;

    Vector2 startPosition;

    private void OnEnable()
    {
        transform.position = StartPosition;
    }

    void Update()
    {
        if (GameManager.instance.isPlay)
        {
            transform.Translate(Vector2.down * Time.deltaTime * GameManager.instance.gameSpeed);

            if (transform.position.x < -10)
            {
                gameObject.SetActive(false);
            }
            else if (transform.position.y < startPosition.y - 2)//-1.4
            {
                jump = false;
                isTop = false;
                //transform.position = startPosition;
            }

            if (transform.position.y <= jumpHeight && !isTop)
            {
                transform.Translate(Vector2.left * Time.deltaTime * jumpSpeed);
            }
            else
            {
                isTop = true;
            }
            if (transform.position.y > startPosition.y - 2 && isTop)
            {
                transform.Translate(Vector2.right * Time.deltaTime * jumpSpeed);
            }
        }
        if(GameManager.instance.isPlay == false)
            OnEnable();
       
    }
}
