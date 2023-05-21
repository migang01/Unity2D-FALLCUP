using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool isCanvasOn;
    public GameObject GameOverCanvas;
    public GameObject SettingCanvas;
    public GameObject Health;
    public GameObject ScoreCanvas;
    public AdsManager ads;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        // check if the score player just got is highscore comparing to previous one
        if (Score.score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Score.score);
        }

        isCanvasOn = true;
        Time.timeScale = 0;
        GameOverCanvas.SetActive(true);
        Health.SetActive(false);
    }


    public void Replay()
    {
        isCanvasOn = false;
        ScoreCanvas.SetActive(true);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Audio.UISoundPlay();
    }

    public void Continue()
    {
        isCanvasOn = false;
        ads.RewardedAd();
        GameOverCanvas.SetActive(false);
        Health.SetActive(true);
        Time.timeScale = 0;
        Audio.UISoundPlay();


    }

    public void SettingContinue()
    {
        isCanvasOn = false;
        GameOverCanvas.SetActive(false);
        ScoreCanvas.SetActive(true);
        SettingCanvas.SetActive(false);
        Health.SetActive(true);
        Time.timeScale = 1;
        Audio.UISoundPlay();
    }

    public void Setting()
    {
        isCanvasOn = true;
        SettingCanvas.SetActive(true);
        Health.SetActive(false);
        Time.timeScale = 0;
        Audio.UISoundPlay();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameScore()
    {
        PlayerPrefs.SetInt("currentScore", Score.score);
    }
}