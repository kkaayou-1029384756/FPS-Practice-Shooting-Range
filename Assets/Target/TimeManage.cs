using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TimeManage : MonoBehaviour
{
    public int cool = 30;
    public bool OK = false;

    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Board;
    public GameObject Timer;
    public GameObject Score;


    void Update()
    {


        if (OK == true)
        {
            Invoke("Time", 1f);
            OK = false;
        }
    }
    void Time()
    {
        if(cool <= 0)
        {
            One.SetActive(false);
            Two.SetActive(false);
            Three.SetActive(false);
            Timer.SetActive(false);
            Board.SetActive(true);
            Score.SetActive(false);
            cool = 30;
            GameObject.Find("ScoreManager").GetComponent<ScoreBoardManage>().End = true;
        } 
        else
        {
            Invoke("Time", 1f);
            cool -= 1;
        }
    }
}
