using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class amo : MonoBehaviour    
{
    public float gageValue = 0f;
    public int bulletQuantity = 25;
    public Scrollbar bar;
    public GameObject scroll;
    public TextMeshProUGUI myText;
    public bool isLoading = false;




    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletQuantity > 0 && isLoading == false)
        {
            bulletQuantity -= 1;
            myText.text = bulletQuantity.ToString() + " / 25";
        }

        if (Input.GetKeyDown(KeyCode.R) && bulletQuantity != 25) 
        {
            isLoading = true;
            scroll.SetActive(true);
            Invoke("Re", 1f);
            bulletQuantity = 25;
            gageValue = 0;
        }

        if (isLoading == true)
        {
            gageValue += Time.deltaTime;
            bar.size = gageValue;
        }
    }
    void Re()
    {
        isLoading = false;
        scroll.SetActive(false);
        myText.text = bulletQuantity.ToString() + " / 25";
    }
}