using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text AllScoreText;
    public static int allIntScore;

    void Update()
    {
        AllScoreText.text = allIntScore.ToString();
    }
    public static void AddScore(int score)
    {
        allIntScore += score;
    }
}
