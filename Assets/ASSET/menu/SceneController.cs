using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }
    public void menugame()
    {
        SceneManager.LoadScene(0);
    }
}
