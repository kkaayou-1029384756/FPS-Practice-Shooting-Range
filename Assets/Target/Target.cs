using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{


    public int point;
    public bool Change = false;
    float maxX = -14.5f;
    float minX = -13.0f;
    float maxY = 10f;
    float minY = 2f;
    float maxZ = 10f;
    float minZ = -10f;


    void ChangePosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        transform.position = new Vector3(randomX, randomY, randomZ);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Change = true;
        GameObject.Find("ScoreManager").GetComponent<ScoreBoardManage>().score += point;
    }
    private void Update()
    {
        if (Change == true)
        {
            ChangePosition();
            Change = false;
        }
    }
}
