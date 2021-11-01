using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleBox : MonoBehaviour
{
    [SerializeField] public ParticleSystem ParticleApple;
    private GameObject Apple;
    public static int ScoreApple;
    void Start()
    {
        ParticleApple.Stop();
        Apple = GameObject.Find("Apple");
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Arrow>())
        {
            ScoreApple = +1000;
            Destroy(Apple);
            ParticleApple.Play();
        }
        
    }
}
