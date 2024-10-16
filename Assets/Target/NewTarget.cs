using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTarget : MonoBehaviour
{
    float maxX = -14.5f;
    float minX = -13.0f;
    float maxY = 20f;
    float minY = 14f;
    float maxZ = 12f;
    float minZ = -13f;  

    private void OnCollisionEnter(Collision collision)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}
