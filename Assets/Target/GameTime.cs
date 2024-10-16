using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameTime : MonoBehaviour
{
    public GameObject GameObject;
    public TextMeshProUGUI timeText;
 
    

    void Update()
    {
        timeText.text = "Time: " + '\n' + GameObject.GetComponent<TimeManage>().cool.ToString() + "/ 30";
    }

}
