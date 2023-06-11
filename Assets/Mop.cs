using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mop : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;

    public void OnEnable()
    {
        transform.position = StartPosition;
    }

    void Update()
    {
        if(GameManager.instance.isPlay)
        {
            transform.Translate(Vector2.left * Time.deltaTime * GameManager.instance.gameSpeed);

            if (transform.position.x < -10)
            {
                gameObject.SetActive(false); 
            }
        }
        if (GameManager.instance.isPlay == false)
            OnEnable();
    }
}
