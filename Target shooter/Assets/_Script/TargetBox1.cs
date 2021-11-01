using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetBox1 : MonoBehaviour
{
    [SerializeField] private int nubmerOfShots2Target=0;
    public static int scoreBox2Target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Arrow>())
        {
            if (nubmerOfShots2Target < 1)
            {
                scoreBox2Target += 100;
                nubmerOfShots2Target++;
            }
        }
        
    }
}
