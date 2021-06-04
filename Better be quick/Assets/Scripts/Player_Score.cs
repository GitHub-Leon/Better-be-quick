using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    public static int scoreValue = 0;

    TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update(){
        scoreText.text = "Score: " + scoreValue;
    }
}
