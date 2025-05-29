using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    // [SerializeField] AudioSource music;
    public bool isPaused;
    public bool canPause;

    void Start()
    {
        Time.timeScale = 1f;

        isPaused = false;
        canPause = true;
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && canPause == true)
        {
            PauseGame();
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        canPause = false;

        // music.volume = 0.05f;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        canPause = true;

        // music.volume = 0.1f;
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        StartCoroutine(FadeBeforeTransition(0));
    }
    
    private IEnumerator FadeBeforeTransition(int sceneIndex)
    {
        Time.timeScale = 1f;
        
        CameraFade.Instance.TriggerFade();

        while (CameraFade.Instance.IsFading())
        {
            yield return null;
        }

        SceneManager.LoadScene(sceneIndex);
    }
}