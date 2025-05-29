using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void PlayGame()
    {
        StartCoroutine(FadeBeforeTransition(1));
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