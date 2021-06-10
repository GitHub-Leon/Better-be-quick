using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public GameObject menu;
    public GameObject deathScreen;

    void Start() {
        if (Player_Score.scoreValue == 0) {
            menu.SetActive(true);
            deathScreen.SetActive(false);
        }
    }

    public void PlayGame() {
        Player_Score.scoreValue = 0;
        SceneManager.LoadScene("Level 01");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void GotoMainMenu() {
        SceneManager.LoadScene("Menu");
    }
}
