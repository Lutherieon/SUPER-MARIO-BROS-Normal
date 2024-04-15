using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartsHealthSystem : MonoBehaviour
{

    [SerializeField] bool isdead;
    void Start()
    {
        isdead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isdead && transform.position.y < -7 )
        {
            isdead = true;
            Die();
        }



    }

    void Die()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
