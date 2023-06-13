using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region instance
    public static GameManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion
    public Player player;
    public GroundMove gMove;
    public Mop mob;
    public moveMob movemob;
    public RespawnMananger res;
    public ScoreBoard scoreboard;

    public delegate void OnPlay(bool isplay);
    public OnPlay onPlay;

    public float gameSpeed = 1;
    public bool isPlay = false;
    public GameObject playBtn;

    public Text scoreText;
    public int score = 0;

    private void Update()
    {
        player.PlayerMove();
        gMove.gMove();
    }

    IEnumerator AddScore()
    {
        while(isPlay)
        {
            score++;
            scoreText.text = score.ToString();
            gameSpeed = gameSpeed + 0.02f;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void PlayBtnClick()
    {
        playBtn.SetActive(false);
        scoreboard.one.SetActive(false);
        scoreboard.two.SetActive(false);
        scoreboard.three.SetActive(false);
        scoreboard.four.SetActive(false);
        scoreboard.five.SetActive(false);
        scoreboard.six.SetActive(false);
        scoreboard.seven.SetActive(false);
        scoreboard.eight.SetActive(false);
        scoreboard.nine.SetActive(false);
        scoreboard.ten.SetActive(false);
        isPlay = true;
        onPlay.Invoke(isPlay);
        score = 0;
        scoreText.text = score.ToString();
        StartCoroutine(AddScore());
    }
    
    public void StopBtnClick()
    {
        isPlay = false;
    }

    //void savesocre()
    //{
    //    oneScore.text = PlayerPrefs.GetInt("highscore").ToString();
    //    twoScore.text = PlayerPrefs.GetInt("highscore2").ToString();
    //    threeScore.text = PlayerPrefs.GetInt("highscore3").ToString();
    //    fourScore.text = PlayerPrefs.GetInt("highscore4").ToString();
    //    fiveScore.text = PlayerPrefs.GetInt("highscore5").ToString();
    //    sixScore.text = PlayerPrefs.GetInt("highscore6").ToString();
    //    sevenScore.text = PlayerPrefs.GetInt("highscore7").ToString();
    //    eightScore.text = PlayerPrefs.GetInt("highscore8").ToString();
    //    nineScore.text = PlayerPrefs.GetInt("highscore9").ToString();
    //    tenScore.text = PlayerPrefs.GetInt("highscore10").ToString();
    //}
    //public void UpdateHighScore()
    //{
    //    if (score > startinghighscore)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", startinghighscore5);
    //        PlayerPrefs.SetInt("highscore5", startinghighscore4);
    //        PlayerPrefs.SetInt("highscore4", startinghighscore3);
    //        PlayerPrefs.SetInt("highscore3", startinghighscore2);
    //        PlayerPrefs.SetInt("highscore2", startinghighscore);
    //        PlayerPrefs.SetInt("highscore", score);
    //    }
    //    else if (score > startinghighscore2)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", startinghighscore5);
    //        PlayerPrefs.SetInt("highscore5", startinghighscore4);
    //        PlayerPrefs.SetInt("highscore4", startinghighscore3);
    //        PlayerPrefs.SetInt("highscore3", startinghighscore2);
    //        PlayerPrefs.SetInt("highscore2", score);
    //    }
    //    else if (score > startinghighscore3)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", startinghighscore5);
    //        PlayerPrefs.SetInt("highscore5", startinghighscore4);
    //        PlayerPrefs.SetInt("highscore4", startinghighscore3);
    //        PlayerPrefs.SetInt("highscore3", score);

    //    }
    //    else if (score > startinghighscore4)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", startinghighscore5);
    //        PlayerPrefs.SetInt("highscore5", startinghighscore4);
    //        PlayerPrefs.SetInt("highscore4", score);
    //    }
    //    else if (score > startinghighscore5)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", startinghighscore5);
    //        PlayerPrefs.SetInt("highscore5", score);
    //    }
    //    else if (score > startinghighscore6)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", startinghighscore6);
    //        PlayerPrefs.SetInt("highscore6", score);
    //    }
    //    else if (score > startinghighscore7)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", startinghighscore7);
    //        PlayerPrefs.SetInt("highscore7", score);
    //    }
    //    else if (score > startinghighscore8)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", startinghighscore8);
    //        PlayerPrefs.SetInt("highscore8", score);
    //    }
    //    else if (score > startinghighscore9)
    //    {
    //        PlayerPrefs.SetInt("highscore10", startinghighscore9);
    //        PlayerPrefs.SetInt("highscore9", score);
    //    }
    //    else if (score > startinghighscore10)
    //    {
    //        PlayerPrefs.SetInt("highscore10", score);
    //    }

    //    startinghighscore = PlayerPrefs.GetInt("highscore");
    //    startinghighscore2 = PlayerPrefs.GetInt("highscore2");
    //    startinghighscore3 = PlayerPrefs.GetInt("highscore3");
    //    startinghighscore4 = PlayerPrefs.GetInt("highscore4");
    //    startinghighscore5 = PlayerPrefs.GetInt("highscore5");
    //    startinghighscore6 = PlayerPrefs.GetInt("highscore6");
    //    startinghighscore7 = PlayerPrefs.GetInt("highscore7");
    //    startinghighscore8 = PlayerPrefs.GetInt("highscore8");
    //    startinghighscore9 = PlayerPrefs.GetInt("highscore9");
    //    startinghighscore10 = PlayerPrefs.GetInt("highscore10");
    //}

    public void GameOver()
    {
        playBtn.SetActive(true);
        playBtn.SetActive(true);
        
        isPlay = false;
        onPlay.Invoke(isPlay);
        StopCoroutine(AddScore());
        gameSpeed = 5.0f;

        scoreboard.one.SetActive(true);
        scoreboard.two.SetActive(true);
        scoreboard.three.SetActive(true);
        scoreboard.four.SetActive(true);
        scoreboard.five.SetActive(true);
        scoreboard.six.SetActive(true);
        scoreboard.seven.SetActive(true);
        scoreboard.eight.SetActive(true);
        scoreboard.nine.SetActive(true);
        scoreboard.ten.SetActive(true);
        scoreboard.UpdateHighScore();
        scoreboard.savesocre();
        
    }

}
