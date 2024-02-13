using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour 
{
    public GameObject menuPause;
    public GameObject buttonPause;

    // Fonction pour changer de scène
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Fonction pour quitter le jeu
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Fonction pour fermer le menu pause
    public void CloseMenu()
    {
        menuPause.SetActive(false);
        buttonPause.SetActive(true);
    }

    // Fonction pour fermer le menu pause
    public void OppenMenu()
    {
        menuPause.SetActive(true);
        buttonPause.SetActive(false);
    }

}

