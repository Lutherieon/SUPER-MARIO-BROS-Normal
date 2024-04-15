using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            levelFinishScore();
            SceneManager.LoadScene("END");
        }        


        void levelFinishScore()
        {

            ScoreManger.score += ((int)ScoreManger.currentTime) * 10;



        }



    }
}
