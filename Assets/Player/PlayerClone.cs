using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class PlayerClone : MonoBehaviour
{
    int amo = 25;
    bool isLoad = false;
    GameObject clone;
    public GameObject GunObject;
    public GameObject Spawn;
    public GameObject gameObjectToRtotation;


    public TextMeshProUGUI GunSkillText;

    RaycastHit hit;


    void Update()
    {
        isLoad = GameObject.Find("GunAmo").GetComponent<amo>().isLoading;
        amo = GameObject.Find("GunAmo").GetComponent<amo>().bulletQuantity;
        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit);
        
        if (Input.GetMouseButtonDown(0) && amo > 0 && isLoad == false)
        {
            clone = Instantiate(GunObject, Spawn.transform.position, gameObject.transform.rotation);
            if (hit.transform != null)
            {
                clone.transform.rotation = Quaternion.LookRotation(hit.point - clone.transform.position);
                clone.GetComponent<Rigidbody>().velocity = clone.transform.forward * 50f;
            }
            else
            {
                Rigidbody rb = clone.GetComponent<Rigidbody>();
                rb.AddForce(gameObject.transform.forward * 50f, ForceMode.Impulse);
            }
        }
    }
}
