using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void FirstLvl()
    {
        SceneManager.LoadScene("1lvl");
    }
    public void TwoLvl()
    {
        SceneManager.LoadScene("2lvl");
    }
    public void Lvls()
    {
        SceneManager.LoadScene("lvls");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
}
