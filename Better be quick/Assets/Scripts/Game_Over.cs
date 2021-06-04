using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Collector") {
            //Game over
            //TODO: Endbildschirm?
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
