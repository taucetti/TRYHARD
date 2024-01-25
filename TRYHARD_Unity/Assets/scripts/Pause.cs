using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public SC_FPSController Player;
    public static bool Paused = false;
    public GameObject pauseMenuCanvas;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Paused){
                Play();
            }
            else{
                Stop();
            }
        }
    }
    public void Quit()
   {
    Application.Quit();
    Debug.Log("Player has quit the Game");
   }

    public void Stop(){
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Player.enabled = false;

    }
    public void Play(){
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
         Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.enabled = true;
    }

    public void MainMenuButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

