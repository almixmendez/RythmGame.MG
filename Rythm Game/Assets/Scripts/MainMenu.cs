using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject HTPPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void HowToPlay()
    {
        HTPPanel.SetActive(true);
    }

    public void GoBackButton()
    {
        HTPPanel.SetActive(false);
    }
}
