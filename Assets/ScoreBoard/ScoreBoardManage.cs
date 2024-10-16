using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreBoardManage : MonoBehaviour
{
    int temp;
    public bool End;
    public int score = 0;

    [SerializeField]
    private int[] Top;
    public TextMeshPro[] TopText = new TextMeshPro[3];

    public int number = 0;

    public TextMeshProUGUI myText;




    void Update()
    {
        myText.text = "Score: " + score.ToString();
        if (End == true)
        {
            End = false;
            number = 0;

            Top[3] = score;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 3; j > i; j--)
                    {
                    if (Top[i] < Top[j])
                        {
                            temp = Top[j];
                            Top[j] = Top[i];
                            Top[i] = temp;
                        }
                    }
                }
            for(number = 0; number < 3; number++)
            {
                TopText[number].text = (number + 1).ToString() + "nd: " + Top[number].ToString();
            }
            score = 0;
            number = 0;
            
        }
    }
}
