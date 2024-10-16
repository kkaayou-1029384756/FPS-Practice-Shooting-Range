using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Shot : MonoBehaviour
{
    public GameObject attack;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Gun")
        {
            Destroy(attack);
        }
    }
}
