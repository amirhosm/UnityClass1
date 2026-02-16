using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject startgameBTN;
    public GameObject endGamePanel;
    public Image timerFill;
    bool gameStarted;
    public bool gameEnded;
    public TextMeshProUGUI coinTxt;
    public TextMeshProUGUI highScoreTxt;
    public TMP_InputField usernameInput;
    int score;
    string username;

    // Start is called before the first frame update
    void Start()
    {
        highScoreTxt.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
    }

    public void StartGame()
    {
        //if (usernameInput.text.Length > 3)
        //{
            startgameBTN.SetActive(false);

            //timerFill.fillAmount = 1;
            gameStarted = true;
            //timerFill.DOFillAmount(0, 5).OnComplete(GameEnd);
        //}
        //else
        //{
           // Debug.Log("Enter Username");
        //}
        
    }

    public void GameEnd()
    {
        gameEnded = true;
        endGamePanel.SetActive(true);

        if (score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
    }

    public void OnBTN_RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AddScore()
    {
        score++;
        coinTxt.text = "" + score;
    }

    //private void Update()
    //{
    //    if (gameStarted)
    //        timerFill.fillAmount -= Time.deltaTime / 30;
    //}
}
