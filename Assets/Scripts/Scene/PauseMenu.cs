using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void PauseGame()
    {
        PauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GamePlay");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }
}
