using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TargetBox : MonoBehaviour
{
    [SerializeField] private int nubmerOfShots=0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (nubmerOfShots < 1)
        {
            Score.AddScore(100);
            nubmerOfShots++;
        }
    }
}
