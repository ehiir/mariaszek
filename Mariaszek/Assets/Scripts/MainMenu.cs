using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject credits, creditsButton;
    bool creditsEnabled;

    void Start()
    {
        Time.timeScale = 1f;

        credits.SetActive(false);
        creditsButton.SetActive(false);
        creditsEnabled = false;
    }

    public void PlayGame()
    {
        StartCoroutine(FadeBeforeTransition(1));
    }

    public void Credits()
    {
        creditsEnabled ^= true;
        credits.SetActive(creditsEnabled);

        if (creditsEnabled == true)
        {
            creditsButton.SetActive(true);
        }
        else
        {
            creditsButton.SetActive(false);
        }
    }

    public void QuitGame()
    {
        StartCoroutine(FadeBeforeTransition(-1));
    }

    private IEnumerator FadeBeforeTransition(int sceneIndex)
    {
        CameraFade.Instance.TriggerFade();

        while (CameraFade.Instance.IsFading())
        {
            yield return null;
        }

        if (sceneIndex >= 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }

        else
        {
            Application.Quit();
        }
    }
}