using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamerManagerScript : MonoBehaviour
{
    public GameObject gameOvertUI;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void gameOver()
    {
        gameOvertUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
        Debug.Log("EndGame");
    }
}
