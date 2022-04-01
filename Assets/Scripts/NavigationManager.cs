using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour
{

    public string startScreen = "GameScreen";
    public string gameoverScreen = "GameOverScreen";
    public string menuScreen = "MenuScreen";
    public string settingsScreen = "SettingsScreen";


    public void LoadGameOver()
    {
        SceneManager.LoadScene(gameoverScreen);
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(startScreen);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(menuScreen);
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene(settingsScreen);
    }

    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(sceneIndex + 1);
    }
    public void LoadPreviousScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        if(sceneIndex > 0)
        {
            SceneManager.LoadScene(sceneIndex - 1);
        }
    }




}
