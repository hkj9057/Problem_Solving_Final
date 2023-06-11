using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text oneScore;
    public Text twoScore;
    public Text threeScore;
    public Text fourScore;
    public Text fiveScore;
    public Text sixScore;
    public Text sevenScore;
    public Text eightScore;
    public Text nineScore;
    public Text tenScore;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public int startinghighscore;
    public int startinghighscore2;
    public int startinghighscore3;
    public int startinghighscore4;
    public int startinghighscore5;
    public int startinghighscore6;
    public int startinghighscore7;
    public int startinghighscore8;
    public int startinghighscore9;
    public int startinghighscore10;

    public void savesocre()
    {
        oneScore.text = PlayerPrefs.GetInt("highscore").ToString();
        twoScore.text = PlayerPrefs.GetInt("highscore2").ToString();
        threeScore.text = PlayerPrefs.GetInt("highscore3").ToString();
        fourScore.text = PlayerPrefs.GetInt("highscore4").ToString();
        fiveScore.text = PlayerPrefs.GetInt("highscore5").ToString();
        sixScore.text = PlayerPrefs.GetInt("highscore6").ToString();
        sevenScore.text = PlayerPrefs.GetInt("highscore7").ToString();
        eightScore.text = PlayerPrefs.GetInt("highscore8").ToString();
        nineScore.text = PlayerPrefs.GetInt("highscore9").ToString();
        tenScore.text = PlayerPrefs.GetInt("highscore10").ToString();
    }
    public void UpdateHighScore()
    {
        if (GameManager.instance.score > startinghighscore)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", startinghighscore5);
            PlayerPrefs.SetInt("highscore5", startinghighscore4);
            PlayerPrefs.SetInt("highscore4", startinghighscore3);
            PlayerPrefs.SetInt("highscore3", startinghighscore2);
            PlayerPrefs.SetInt("highscore2", startinghighscore);
            PlayerPrefs.SetInt("highscore", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore2)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", startinghighscore5);
            PlayerPrefs.SetInt("highscore5", startinghighscore4);
            PlayerPrefs.SetInt("highscore4", startinghighscore3);
            PlayerPrefs.SetInt("highscore3", startinghighscore2);
            PlayerPrefs.SetInt("highscore2", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore3)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", startinghighscore5);
            PlayerPrefs.SetInt("highscore5", startinghighscore4);
            PlayerPrefs.SetInt("highscore4", startinghighscore3);
            PlayerPrefs.SetInt("highscore3", GameManager.instance.score);

        }
        else if (GameManager.instance.score > startinghighscore4)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", startinghighscore5);
            PlayerPrefs.SetInt("highscore5", startinghighscore4);
            PlayerPrefs.SetInt("highscore4", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore5)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", startinghighscore5);
            PlayerPrefs.SetInt("highscore5", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore6)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", startinghighscore6);
            PlayerPrefs.SetInt("highscore6", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore7)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", startinghighscore7);
            PlayerPrefs.SetInt("highscore7", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore8)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", startinghighscore8);
            PlayerPrefs.SetInt("highscore8", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore9)
        {
            PlayerPrefs.SetInt("highscore10", startinghighscore9);
            PlayerPrefs.SetInt("highscore9", GameManager.instance.score);
        }
        else if (GameManager.instance.score > startinghighscore10)
        {
            PlayerPrefs.SetInt("highscore10", GameManager.instance.score);
        }

        startinghighscore = PlayerPrefs.GetInt("highscore");
        startinghighscore2 = PlayerPrefs.GetInt("highscore2");
        startinghighscore3 = PlayerPrefs.GetInt("highscore3");
        startinghighscore4 = PlayerPrefs.GetInt("highscore4");
        startinghighscore5 = PlayerPrefs.GetInt("highscore5");
        startinghighscore6 = PlayerPrefs.GetInt("highscore6");
        startinghighscore7 = PlayerPrefs.GetInt("highscore7");
        startinghighscore8 = PlayerPrefs.GetInt("highscore8");
        startinghighscore9 = PlayerPrefs.GetInt("highscore9");
        startinghighscore10 = PlayerPrefs.GetInt("highscore10");
    }
}
