using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateStar : MonoBehaviour
{
    [SerializeField] private GameObject iStar1;
    [SerializeField] private GameObject iStar2;
    [SerializeField] private GameObject iStar3;

    public void Instantiate()
    {
        if (BowScript.countStar > 0)
        {
            StartCoroutine(Star());
        }
    }
    
    private IEnumerator Star()
    {
        if (BowScript.countStar ==1)
        {
            yield return new WaitForSeconds(.2f);
            iStar1.SetActive(true);
        }
        else if (BowScript.countStar==2)
        {
            yield return new WaitForSeconds(.2f);
            iStar1.SetActive(true);
            yield return new WaitForSeconds(.3f);
            iStar2.SetActive(true);
        }
        else if (BowScript.countStar ==3)
        {
            yield return new WaitForSeconds(.2f);
            iStar1.SetActive(true);
            yield return new WaitForSeconds(.3f);
            iStar2.SetActive(true);
            yield return new WaitForSeconds(.4f);
            iStar3.SetActive(true);
        }
       
        
    }
}
