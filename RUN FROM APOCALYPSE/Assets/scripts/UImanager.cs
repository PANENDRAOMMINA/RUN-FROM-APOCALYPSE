using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    
   public void resume()
    {
        
        Time.timeScale = 1f;
        GameObject.Find("pause").SetActive(false);
        player.instance._ispaused = false;
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void tutorial()
    {
        SceneManager.LoadScene(2);
    }
    public void Game()
    {
        SceneManager.LoadScene(3);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void game()
    {
        SceneManager.LoadScene(1);
    }
    public void about()
    {
        SceneManager.LoadScene(4);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void touchstart()
    {
        SceneManager.LoadScene(6);
    }
    public void retrytutorial()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
        
    }
    public void retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }


}
