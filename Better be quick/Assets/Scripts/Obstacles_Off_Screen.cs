using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Off_Screen : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Collector") {
            gameObject.SetActive(false);
        }
    }
}
