using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Text iAllScore;
    public static int allIntScore;

    public void Update()
    {
        
        allIntScore = TargetBox.scoreBox + AppleBox.ScoreApple+TargetBox1.scoreBox2Target;
    }
}
