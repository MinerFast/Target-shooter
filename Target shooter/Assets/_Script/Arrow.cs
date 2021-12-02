using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    private bool hasHit;
    public static bool check; 
    void Start()
    {
        check = false;
        rb = GetComponent<Rigidbody2D>();     
    }

    void Update()   
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.GetComponent<BoxCollider2D>().enabled == false)
        {
            return;
        }
        this.GetComponent<BoxCollider2D>().enabled = false;
        BowScript.checkArrowFly++;
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
      
   
    }
}
