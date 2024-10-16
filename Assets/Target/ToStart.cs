using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ToStart : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Board;
    public GameObject GameObject;
    public GameObject Timer;
    public GameObject Score;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GameObject.Find("ScoreManager").GetComponent<TimeManage>().OK = true;
            Board.SetActive(false);
            One.SetActive(true);
            Two.SetActive(true);
            Three.SetActive(true);
            Timer.SetActive(true);
            Score.SetActive(true);
            for (int i = 1; i <= 5; i+=2)
            {
                GameObject.Find(i + "point").GetComponent<Target>().Change = true;
            }
        }
    }
}
