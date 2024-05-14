using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    public GameObject retry;
    public GameObject mainMenu;
    public GameObject quit;

    public void QuitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void MainMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Retry(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
