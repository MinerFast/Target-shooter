using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject Cloud;
    private const int lifeCloud=47;
    void Start()
    {
        SpawnCloud();
    }

    void SpawnCloud()
    {
        
        Instantiate(Cloud, transform.position, Quaternion.identity);
        Invoke("SpawnCloud", lifeCloud);
    }
}
