using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{

    public GameObject arrow;
    [SerializeField] private float LaunchForce;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject ArrowIns = Instantiate(arrow, transform.position, transform.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;
    }
}
