using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void StartGame()
    {
        SceneManager.LoadScene("GamePrototype");
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
    public void ReturnToMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
}
