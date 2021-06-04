using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour{
    public ScoreManager scoreManager;

    private string name;
    public GameObject inputField;

    public void SaveScore() {
        name = inputField.GetComponent<Text>().text;
        Debug.Log(name);
        scoreManager.AddScore(new Score(name, Player_Score.scoreValue));
    }
}
