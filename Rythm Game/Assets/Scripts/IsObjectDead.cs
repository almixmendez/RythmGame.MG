using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsObjectDead : MonoBehaviour
{
    public string mainMenuSceneName = "MainMenu";

    private void OnDisable()
    {
        if (!this.gameObject.activeInHierarchy)
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}
