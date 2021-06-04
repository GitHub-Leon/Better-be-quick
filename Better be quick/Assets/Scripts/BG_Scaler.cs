using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;

        if (gameObject.name == "Background") {
            transform.localScale = new Vector3(width, height, 0); //scalierung des BG
        } else if (gameObject.name == "Foreground") {
            transform.localScale = new Vector3(width+ 3f, 2, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
