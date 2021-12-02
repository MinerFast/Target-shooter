using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void ChoisetLvl(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
    public void Restart()
    {
        Scene SceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneLoaded.buildIndex);
        Score.allIntScore = 0;
        BowScript.checkArrowFly = 0;
    }    
    public void NextLevel()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
        Score.allIntScore = 0;
        BowScript.checkArrowFly = 0;
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
