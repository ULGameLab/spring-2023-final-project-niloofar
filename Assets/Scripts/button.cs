using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Build number of scene to start when start btn is pressed
    public int StartScene = 0;
    public int Instructions = 1;
    public int MainScene = 2;
    public int GameOver = 3;
    // handling the buttons & other scenes
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(MainScene);
    }

    public void LoadInstruction()
    {
        SceneManager.LoadScene(Instructions);
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(StartScene);
    }


    public void QuitGame()
    {
         UnityEditor.EditorApplication.isPlaying = false;
        //Debug.Log("Quit the game!");
        Application.Quit();
    }

   
}
