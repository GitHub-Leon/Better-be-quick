using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void PlayGame() {
        Player_Score.scoreValue = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Level 01");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void GotoMainMenu() {
        SceneManager.LoadScene("Menu");
    }
}
