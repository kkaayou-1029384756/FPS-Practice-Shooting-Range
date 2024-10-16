using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewStart : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;
    public GameObject Three;

    public int Level;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if (Level == 1)
            {
                One.SetActive(true);
                Two.SetActive(false);
                Three.SetActive(false);
            }

            if (Level == 2) 
            {
                Two.SetActive(true); 
                One.SetActive(false);
                Three.SetActive(false);
            } 
            if (Level == 3)
            {
                Three.SetActive(true); 
                One.SetActive(false); 
                Two.SetActive(false);
            }

        }
    }
}
