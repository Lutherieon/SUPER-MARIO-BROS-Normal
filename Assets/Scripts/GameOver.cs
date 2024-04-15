using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] Text scoreDisplayText;
    [SerializeField] Text highScoreDisplayText;
    void Start()
    {
        scoreDisplayText.text = "Score: " + ScoreManger.score.ToString();
        highScoreDisplayText.text = "highScore:" + PlayerPrefs.GetInt("highScore").ToString();

    }

    void Update()
    {
    }

    public void Reload()
    {

        SceneManager.LoadScene("SampleScene");
    }

}
