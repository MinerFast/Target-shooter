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
    public void Restart()
    {
        Scene SceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneLoaded.buildIndex);
    }    
    public void NextLevel()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
