using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBox2 : MonoBehaviour
{
    [SerializeField] private int nubmerOfShots = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (nubmerOfShots < 1)
        {
            Score.AddScore(100);
            nubmerOfShots++;
        }

    }
}
