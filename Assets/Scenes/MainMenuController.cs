using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    Public CanvasGroup OptionalPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex + 1);
    }

    public void Option()
    {
         OptionPanel.alpha = 1;
         OptionPanel.blocksRaycasts = true;
    } 
    
    public void Back()
    {
         OptionPanel.alpha = 0;
         OptionPanel.blocksRaycasts = false;
    }

   
    public void QuitGame()
    {
        Application.Quit();
    }

}
