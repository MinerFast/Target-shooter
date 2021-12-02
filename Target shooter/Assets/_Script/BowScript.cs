using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class BowScript : MonoBehaviour
{
    UnityEvent Shot;
    [Header("Text")]
    [SerializeField] private Text TextNumberOfShotes;
    [SerializeField] private Transform shotPoint;
    [Header("Points")]
    [SerializeField] private GameObject point;
    [SerializeField] private GameObject[] points;
    [SerializeField] private float spaceBetweenPoints;
    [SerializeField] private int numberOfpoints;
    [Header("GameObjects")]
    [SerializeField] private GameObject starHelper;
    [SerializeField] private GameObject arrow;
    [Header("UI elements")]
    [SerializeField] private GameObject PanelWin;
    [SerializeField] private GameObject PanelLose;
    [SerializeField] private GameObject Joystick;
    public static int countStar=0;
    [Header("Check score")]
    [SerializeField] private int CheckAllScore;
    [SerializeField] private int AlternativeScore;
    [Header("")]
    [SerializeField] private int NumberOfShotes;
    [SerializeField] private float launchForce;
    [SerializeField] public static int checkArrowFly;
    [SerializeField] private int checkArrowFlyHepler;
    private InstantiateStar star;

    Vector2 direction;

    #region LIFECYCLE 
    public void Start()
    {
        star = starHelper.GetComponent<InstantiateStar>();
        checkArrowFly = 0;
        checkArrowFlyHepler = NumberOfShotes;
        if (Shot == null)
            Shot = new UnityEvent();
        Shot.AddListener(Shoot);
      

        TextNumberOfShotes.text = NumberOfShotes.ToString();
        Joystick.SetActive(true);
        Time.timeScale = 1f;
        this.GetComponent<BowScript>().enabled = true;
        TextNumberOfShotes.text = NumberOfShotes.ToString();
        points = new GameObject[numberOfpoints];
        for (int i = 0; i < numberOfpoints; i++)
        {
            points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
        }
    }
    #endregion
    #region EVENT
   
    public void Shoot()
    {
        if (NumberOfShotes > 0)
        {
            NumberOfShotes--;
            TextNumberOfShotes.text = NumberOfShotes.ToString();
            GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
            Arrow.check = false;
        }
    }
 
    #endregion
    public void Update()
    {
        Debug.Log(Score.allIntScore);
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePosition - bowPosition;
        transform.right = direction;

        if (Input.touchCount > 0)
        {
            Touch _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Ended)
            {
                Shot?.Invoke();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot?.Invoke();
        }

        for (int i = 0; i < numberOfpoints; i++)
        {
            points[i].transform.position = pointPosition(i * spaceBetweenPoints);
        }
        if (Score.allIntScore == CheckAllScore  
            || Score.allIntScore == AlternativeScore && NumberOfShotes <= 0 && checkArrowFlyHepler == checkArrowFly) 
        {
            Score.AddScore(NumberOfShotes * 50);
            PanelWin.SetActive(true);
            if (Score.allIntScore >= CheckAllScore && NumberOfShotes > 0)
            {
                countStar = 3;
                star.Instantiate();
            }
            if (Score.allIntScore >= CheckAllScore && NumberOfShotes == 0)
            {
                countStar = 2;
                star.Instantiate();
            }
            if (Score.allIntScore >= AlternativeScore && Score.allIntScore <=CheckAllScore)
            {
                countStar = 1;
                star.Instantiate();
            }
            this.GetComponent<BowScript>().enabled = false;
            Joystick.SetActive(false);
        }
        else if (Score.allIntScore != CheckAllScore && Score.allIntScore != AlternativeScore && NumberOfShotes <= 0 && checkArrowFlyHepler == checkArrowFly)
        {
            PanelLose.SetActive(true);
            this.GetComponent<BowScript>().enabled = false;
            Joystick.SetActive(false);
        }
       
    }

    Vector2 pointPosition(float t)
    {
        Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }

}
