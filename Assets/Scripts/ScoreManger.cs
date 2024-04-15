using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class ScoreManger : MonoBehaviour
{
    public static ScoreManger Instance; 
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] Collider2D playerCollider;
    public static int score;
    int highScore;


    float maxTime = 120;
    public static float currentTime;
    [SerializeField] Text CurrentTimeText;


    void Timer()
    {
        maxTime -= Time.deltaTime;
        currentTime = maxTime;


    }



    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        score = 0;  
        highScoreText.text = "HighScore:" + highScore.ToString();
    }

    void Update()
    {

        
        Timer();
        print(currentTime);
        CurrentTimeText.text = "CurrentTime: " + currentTime.ToString("0"); // "0" kusuratlari siler  



        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "HighScore:" + PlayerPrefs.GetInt("highScore").ToString();
        if (score> PlayerPrefs.GetInt("highScore") )
        {
            PlayerPrefs.SetInt("highScore", score);
        }
       
    }



  
    void CountScore()
    {
        score += ((int)(currentTime * 10));
    }



}
